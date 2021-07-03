
import java.awt.Color;
import java.util.ArrayList;
import java.util.List;
import java.util.Random;


public class Engine 
{
    private String log;
    private List<Player> gracze = new ArrayList(4);
    private int aktywny_gracz=0;

    public Engine() 
    {
        
        for(int x=0;x<4;x++)
        {
            gracze.add( new Player("Gracz"+x,Color.red,0,3000.0));
        }
        
        log="Witamy "+ gracze.get(0).getName()+", "+gracze.get(1).getName()+", "+gracze.get(2).getName()+", "+gracze.get(3).getName()+" \nŻyczymy miłej gry\nAktywny gracz: "+gracze.get(aktywny_gracz).getName(); 
        
    }
   
    public Player getPlayer(int x)
    {
        return gracze.get(x);
    }
    
    public Player getAktywnyPlayer()
    {
        return gracze.get(aktywny_gracz);
    }
            
    public String getLog() 
    {
        return log;
    }

    public void setLog(String log) 
    {
        this.log = log;
    }
    
    public void koniecTury()
    {
        if(aktywny_gracz+1<gracze.size())
        {
            aktywny_gracz=aktywny_gracz+1;
            log=log+"\nAktywny gracz: "+gracze.get(aktywny_gracz).getName();
        }
        else
        {
            aktywny_gracz=0;
            log=log+"\nAktywny gracz: "+gracze.get(aktywny_gracz).getName();
        }
    }
    
    public void random2k6()
    {
        Random ran = new Random();
        int randomNum = (ran.nextInt(5) + 1) + ran.nextInt(5) + 1;
        gracze.get(aktywny_gracz).setWhere(gracze.get(aktywny_gracz).getWhere()+randomNum);
        log=log + "\n" + gracze.get(aktywny_gracz).getName()+" wyrzucił "+ randomNum + " i przesuwa sie na pole "+gracze.get(aktywny_gracz).getWhere() ;
    }
}
