/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package umonopoly.v2;

import java.util.ArrayList;
import java.util.List;

/**
 *
 * @author Oskar
 */
public class Player 
{
    private int id;
    private String name;
    private Double money;
    private List<Integer> player_hand;
    private String kolor;
    private int where;
    
    
    public Player()
    {
        name = "player";
        where = 0;
        player_hand = new ArrayList<Integer>();
        money = 3000.0;
    }
        
    public Player(int iD,String imie, String kolor )
    {
        id=iD;
        name = imie;
        where = 0;
        player_hand = new ArrayList<Integer>();
        money = 3000.0;
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

    public String getKolor() {
        return kolor;
    }

    public void setKolor(String kolor) {
        this.kolor = kolor;
    }

    public int getWhere() 
    {
        return where;
    }

    public void setWhere(int where) 
    {
        if(where<40)
        {
            this.where = where;
        }
        else
        {
            this.where= where-40;
        }
            
            
    }
    
    public void addToHand(int x)
    {
        player_hand.add(x);
    }
    public int getHand(int x)
    {
        return player_hand.get(x);
    }
    
    public int sizeHand()
    {
        return player_hand.size();
    }

    public List<Integer> getPlayer_hand() {
        return player_hand;
    }
    
    

    public int getId() {
        return id;
    }
         
    
}
