using System;
public class StopWatch
{
    private DateTime startTime;
    private DateTime endTime;
    public DateTime getStartTime()
    {
        return this.startTime;
    }
    public void setStartTime(DateTime startTime)
    {
        this.startTime = startTime;
    }
    public DateTime getEndTime()
    {
        return this.endTime;
    }
    public void setEndTime(DateTime endTime)
    {
        this.endTime = endTime;
    }
    public void Start(){

        setStartTime(DateTime.Now);
    }
    public void Stop(){
        setEndTime(DateTime.Now);
    }
    public TimeSpan GetElapsedTime(){
        DateTime start = getStartTime();
        DateTime end = getEndTime();
        return end-start;
    }
}