/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package umonopoly.v2;

/**
 *
 * @author Oskar
 */

import java.util.ArrayList;
import java.util.List;
import java.util.Random;
import java.util.Vector;


public class Engine 
{
    private String log;
    private List<Player> gracze;
    private int aktywny_gracz=0;
    private List<Card> pola=new ArrayList(40);
    

    public Engine(int x, Vector <String> name,Vector <String> kolor) 
    {
        gracze = new ArrayList(x);
        log="";
        for(int i=0;i<x;i++)
        {
            gracze.add( new Player(i,name.get(i),kolor.get(i)));
            log=log+"Witamy "+ gracze.get(i).getName()+"\n";
            
        }
        log=log+"Życzymy miłej gry\nAktywny gracz: "+gracze.get(aktywny_gracz).getName(); 
        
        pola.add(new Card(1));
        pola.add(new Card(2, "Kierunek Projektowanie mebli i wyrobów drewnianych",120, 10, 40, 120, 360, 640, 900, 100));
        pola.add(new Card(3));
        pola.add(new Card(4, "Kierunek Inzynieria i automatyzacja w przemysle drewnianym",120, 10, 40, 120, 360, 640, 900, 100));
        pola.add(new Card(5));
        pola.add(new Card(6, "MZK Koszalin Przystanek Poludniowy", 400 , 50, 100, 200, 400, 0, 0, 0));
        pola.add(new Card(7, "Kierunek Energetyka", 200, 15, 60, 180, 540, 800, 1100, 100));
        pola.add(new Card(8));
        pola.add(new Card(9, "Kierunek Mechanika i budowa maszyn", 200, 15, 60, 180, 540, 800, 1100, 100));
        pola.add(new Card(10, "Kierunek Transport", 240, 20, 80, 200, 600, 900, 1200, 100));
        pola.add(new Card(11));
        pola.add(new Card(12, "Kierunek Budownictwo", 280, 20, 100, 300, 900, 1250, 1500, 200));
        pola.add(new Card(13, "Klub Studencki", 300, 10, 0, 0, 0,0, 0, 0));
        pola.add(new Card(14, "Kierunek Inzynieria srodowiska", 280, 20, 100, 300, 900, 1250, 1500, 200));
        pola.add(new Card(15, "Kierunek Ochrona srodowiska", 320, 25, 120, 360, 1000, 1400, 1850, 200));
        pola.add(new Card(16, "MZK Koszalin Przystanek Zachodni", 400, 50, 100, 200, 400, 0, 0, 0));
        pola.add(new Card(17, "Kierunek Dziennikarstwo i komunikacja spoleczna", 360, 30, 140, 400, 1100, 1500, 1900, 200));
        pola.add(new Card(18));
        pola.add(new Card(19, "Kierunek Polityka", 360, 30, 140, 400, 1100, 1500, 1900, 200 ));
        pola.add(new Card(20, "Kierunek Filologia", 400, 35, 160, 440, 1200, 1600, 2000, 200));
        pola.add(new Card(21));
        pola.add(new Card(22, "Kierunek Inżyniera Biomedyczna", 440, 35, 180, 500, 1400, 1750, 2100, 300));
        pola.add(new Card(23));
        pola.add(new Card(24, "Kierunek Pedagokia", 440, 35, 180, 500, 1400, 1750, 2100, 300));
        pola.add(new Card(25, "Kierunek Mechatronika", 480, 40, 200, 600, 1500, 1850, 2200, 300));
        pola.add(new Card(26, "MZK Koszalin Przystanek Polnocny", 400, 50, 100, 200, 400, 0, 0, 0)); 
        pola.add(new Card(27, "Kierunek Ekonomia", 520, 45, 220, 660, 1600, 1950, 2300, 300));
        pola.add(new Card(28, "Kierunek Finanse i rachunkowosc", 520, 45, 220, 660, 1600, 1950, 2300, 300));
        pola.add(new Card(29, "Pizzeria", 300, 10, 0, 0, 0,0, 0, 0));
        pola.add(new Card(30, "Kierunek Zarzadzanie", 560, 50, 240, 720, 1700, 2050, 2400, 300));
        pola.add(new Card(31));
        pola.add(new Card(32, "Kierunek Wzornictwo", 600, 55, 260, 780, 1900, 2200, 2550, 400));
        pola.add(new Card(33, "Kierunek Sztuka i media", 600, 55, 260, 780, 1900, 2200, 2550, 400));
        pola.add(new Card(34));
        pola.add(new Card(35, "Kierunek Malarstwo", 640, 60, 300, 900, 2000, 2400, 2800, 400));
        pola.add(new Card(36, "MZK Koszalin Przystanek Wschodni", 400, 50, 100, 200, 400, 0, 0,0));
        pola.add(new Card(37));
        pola.add(new Card(38, "Kierunek Elektronika i telekomunikacja", 700, 70, 350, 1000, 2200, 2600, 3000, 400));
        pola.add(new Card(39));
        pola.add(new Card(40, "Kierunek Informatyka", 800, 100, 400, 1200, 2800, 3400, 4000, 400));   
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
    
    public Card getPole(int x)
    {
        return pola.get(x);
    }
    
     public Player getGracze(int x)
    {
        return gracze.get(x);
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
    
    public int getSizeOfPlayer()
    {
        return gracze.size();
    }
    
    public void random2k6()
    {
        Random ran = new Random();
        Random ran1 = new Random();
        int randomNum = (ran.nextInt(5) + 1) + ran1.nextInt(5) + 1;
        if(gracze.get(aktywny_gracz).getWhere()+randomNum>40)
        {
            gracze.get(aktywny_gracz).setMoney(gracze.get(aktywny_gracz).getMoney()+400);
        }
        gracze.get(aktywny_gracz).setWhere(gracze.get(aktywny_gracz).getWhere()+randomNum);
        log=log + "\n" + gracze.get(aktywny_gracz).getName()+" wyrzucił "+ randomNum + " i przesuwa sie na pole "+(gracze.get(aktywny_gracz).getWhere()+1); 
    }
}

