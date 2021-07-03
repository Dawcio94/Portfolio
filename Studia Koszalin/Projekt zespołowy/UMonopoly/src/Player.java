import java.awt.Color;
import java.util.ArrayList;
import java.util.List;

public class Player 
{
    
    private String name;
    private Double money;
    private List<Integer> player_hand;
    private Color kolor;
    private int where;
    
    
    public Player()
    {
        name = "player";
        where = 40;
        player_hand = new ArrayList<Integer>();
        money = 3000.0;
    }
        
    public Player(String imie, Color kolor )
    {
        name = imie;
        where = 40;
        player_hand = new ArrayList<Integer>();
        money = 3000.0;
        this.kolor = kolor;
    }
     
    public Player(String imie, Color kolor, int start, Double pieniadze)
    {
        name = imie;
        where = start;
        player_hand = new ArrayList<Integer>();
        money = pieniadze;
        this.kolor = kolor;
    }
    
    
    public String getName() 
    {
        return name;
    }

    public void setName(String name) 
    {
        this.name = name;
    }

    public Double getMoney() 
    {
        return money;
    }

    public void setMoney(Double money) 
    {
        this.money = money;
    }

    public Color getKolor() {
        return kolor;
    }

    public void setKolor(Color kolor) {
        this.kolor = kolor;
    }

    public int getWhere() 
    {
        return where;
    }

    public void setWhere(int where) 
    {
        if(where<41)
        {
            this.where = where;
        }
        else
        {
            this.where= where-40;
        }
            
            
    }
         
}
