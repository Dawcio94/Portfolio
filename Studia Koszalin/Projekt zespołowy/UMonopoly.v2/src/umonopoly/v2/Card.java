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
public class Card 
{
    private int ID;
    private String name;
    private int domki;
    private double buy_out;
    private double hipoteka;
    private double pay_0;
    private double pay_1;
    private double pay_2;
    private double pay_3;
    private double pay_4;
    private double pay_H;
    private double pay_All;
    private double home;
    private int owner;
	
	
	/**
	 * Tworzy obiekt karty z podanymi wartościami
	 * @param id, unikatowy identyfikator karty
	 * @param nazwa, nazwa karty
	 * @param buy_price, cena kupna karty
	 * @param zastaw_hipoteka, cena zastawienia w hipotekę
	 * @param pay0, kwota do zapłacenia po najechaniu na puste pole
	 * @param pay1, kwota do zapłacenia po najechaniu na pole
	 * 				z jednym domem.
	 * @param pay2, kwota do zapłacenia po najechaniu na pole
	 * 				z dwoma domami.
	 * @param pay3, kwota do zapłacenia po najechaniu na pole 
	 * 				z trzema domami.
	 * @param pay4, kwota do zapłacenia po najechaniu na pole
	 * 				z czterema domami.
	 * @param payH, kwota do zapłacenia po najechaniu na pole
	 * 				z hotelem.
	 * @param payAll, kwota do zapłacenia po najechaniu na pole
	 * 				gdy gracz posiada całe państwo.
	 * @param home_price, cena jednego domu.
	 */
        
        
	public Card(int ID){
		this.ID = ID;
                owner=10;
	}

    public Card(int id, String nazwa, double buy_price, double pay0, double pay1, double pay2, double pay3, double pay4, double payH, double home_price) {
        ID = id;
        name = nazwa;
        domki=0;
        buy_out = buy_price;
        hipoteka = buy_price/2;
        pay_0 = pay0;
        pay_1 = pay1;
        pay_2 = pay2;
        pay_3 = pay3;
        pay_4 = pay4;
        pay_H = payH;
        pay_All = pay0*2;
        home = home_price;
        owner = 5;
    }

    public int getID() {
        return ID;
    }

    public String getName() {
        return name;
    }

    public double getBuy_out() {
        return buy_out;
    }

    public double getHome() {
        return home;
    }

    public double getKoszt()
    {
        switch (domki)
        {
            default:
                    return pay_0;
            
            case 1:
                return pay_1;
                
            case 2:
                return pay_2;
                  
            case 3:
                return pay_3;
                
            case 4:
                return pay_4;
                
            case 5:
                return pay_H;
        }
    }
    
    public void setDomki(int x)
    {
        domki=x;
    }
    
    public int getDomki()
    {
        return domki;
    }
    
    

    public int getOwner() {
        return owner;
    }

    public void setOwner(int owner) {
        this.owner = owner;
    }
         
}
