package vrp;
import java.sql.Time;
public class point 
{
    private int id;
    private String miasto;
    private Time timeMin;
    private Time timeMax;
    
    public point(int id,String miasto, int hours,int minutes,int hours1,int minutes1)
    {
        this.id=id;
        this.miasto=miasto;
        this.timeMax=new Time(hours1,minutes1,0);
        this.timeMin=new Time(hours,minutes,0);
        
    }
    
    public int getId()
    {
        return id;
    }
    
    public String getMiasto()
    {
        return miasto;
    }
    
    public int getTimeMinH()
    {
        return timeMin.getHours();
    }
    
    public int getTimeMinM()
    {
        return timeMin.getMinutes();
    }
    
     public int getTimeMaxH()
    {
        return timeMax.getHours();
    }
    
    public int getTimeMaxM()
    {
        return timeMax.getMinutes();
    }
    public String getText()
    {
        String text = Integer.toString(id)+" "+miasto+ " "+Integer.toString(timeMin.getHours())+":"+Integer.toString(timeMin.getMinutes())+" - "+Integer.toString(timeMax.getHours())+":"+Integer.toString(timeMax.getMinutes());
            return text;
    }
    
    public String getID()
    {
        return Integer.toString(id);
    }
    
}
