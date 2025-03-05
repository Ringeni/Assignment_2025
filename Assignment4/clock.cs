using System;
public class AlarmClock
{
    public event EventHandler<(int minutes, int seconds)> Tick;
    public event EventHandler Alarm;
    private int _minutes;
    private int _seconds;
    private bool _isRunning;
    private Timer _timer;
    public AlarmClock(int minutes, int seconds)
    {
        _minutes = minutes;
        _seconds = seconds;
        _isRunning = false;
    }
    public void Start()
    {
        if (_isRunning) return;
        _isRunning=true;
        _timer=new Timer(TimerCallback,null,0,1000);
    }
    public void Stop()
    {
        if(!_isRunning) return;
        _isRunning=false;
        _timer.Dispose();
    }
    private void TimerCallback(object state)
    {
        _seconds--;
        if(_seconds<0)
        {
            _seconds=59;
            _minutes--;
            if(_minutes<0)
            {
                _minutes=0; 
                OnAlarm();
                Stop();
            }
        }
        OnTick(_minutes,_seconds);
    }
    protected virtual void OnTick(int minutes,int seconds)
    {
        Tick?.Invoke(this, (minutes,seconds));
    }
    protected virtual void OnAlarm()
    {
        Alarm?.Invoke(this,EventArgs.Empty);
    }
}
class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine("Enter the number of minutes and seconds for the alarm:");
        string inStr;
        int minutes,seconds;
        bool valid;
        do
        {
            Console.WriteLine("Minutes:");
            inStr=Console.ReadLine();
            valid=int.TryParse(inStr,out minutes);
            if(minutes<0) valid=false;
        }while(!valid);
        Console.WriteLine($"Minutes:{minutes}");
        do
        {
            Console.WriteLine("Seconds:");
            inStr=Console.ReadLine();
            valid=int.TryParse(inStr,out seconds);
            if(seconds<0||seconds>59) valid=false;
        }while(!valid);
        Console.WriteLine($"Seconds:{seconds}");
        var clock=new AlarmClock(minutes,seconds);
        clock.Tick+=(sender,e)=>
        {
            Console.WriteLine($"Time left:{e.minutes:D2}:{e.seconds:D2}");
        };
        clock.Alarm+=(sender,e)=>
        {
            Console.WriteLine("Alarm!");
            Environment.Exit(0);
        };
        clock.Start();
        Console.WriteLine("Press Enter to stop the alarm...");
        Console.ReadLine();
        clock.Stop();
        Console.WriteLine("Clock Stopped.");
    }
}