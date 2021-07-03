/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package umonopoly.v2;

import java.util.List;
import java.util.Vector;
import javax.swing.JLabel;

/**
 *
 * @author Oskar
 */
public class Player_Hand extends javax.swing.JPanel {

    
    private Vector<JLabel> etykiety = new Vector<>();
   
    public void setPlayer_hand(List<Integer> player_hand) {
     
        for(int z=0;z<etykiety.size();z++)
        {
            etykiety.get(z).setText("");
        }
        
        for (int x=0;x<player_hand.size();x++)
        {
            switch(player_hand.get(x))
            {
            case 2:
                etykiety.get(x).setText(player_hand.get(x)+" Projektowanie Mebli ");
                break;
            case 4:             
                etykiety.get(x).setText(player_hand.get(x)+" Inżynieria i automatyzacja w przemyśle drzewnym ");
                break;
            case 6:              
                etykiety.get(x).setText(player_hand.get(x)+" MZK Koszalin S ");
                break;
            case 7:
                etykiety.get(x).setText(player_hand.get(x)+" Energetyka");
                break;
            case 9:
                
                etykiety.get(x).setText(player_hand.get(x)+" Mechanika i Budowa maszyn ");
                break;
            case 10:
               
                etykiety.get(x).setText(player_hand.get(x)+" Transport ");
                break;
            case 12:
                
               etykiety.get(x).setText(player_hand.get(x)+" Budownictwo");
                break;
            case 13:
              
                etykiety.get(x).setText(player_hand.get(x)+" Klub Studencki");
                break;
            case 14:
                
                etykiety.get(x).setText(player_hand.get(x)+" Inzynieria środowiska");
                break;
            case 15:
               etykiety.get(x).setText(player_hand.get(x)+" Ochrona środowiska");
                break;
            case 16:
               
                etykiety.get(x).setText(player_hand.get(x)+" MZK Koszalin W");
                break;
            case 17:
                
                etykiety.get(x).setText(player_hand.get(x)+" Europejstyka");
                break;
            case 19:
              etykiety.get(x).setText(player_hand.get(x)+" Dziennikarstwo i komunikacja spoleczna");
                break;
            case 20:
               
                etykiety.get(x).setText(player_hand.get(x)+" Filologia");
                break;
            case 22:
               
                etykiety.get(x).setText(player_hand.get(x)+" Inzynieria Biomedyczna");
                break;
            case 24:
               
               etykiety.get(x).setText(player_hand.get(x)+" Pedagogika");
                break;
            case 25:
                
                etykiety.get(x).setText(player_hand.get(x)+" Mechatronika");
                break;
            case 26:
               
               etykiety.get(x).setText(player_hand.get(x)+" MZK KOszalin N");
                break;
            case 27:
                
            etykiety.get(x).setText(player_hand.get(x)+" Ekonomia");
                break;
            case 28:
               
               etykiety.get(x).setText(player_hand.get(x)+" Finanse i rachunkowosc");
                break;
            case 29:
                
                etykiety.get(x).setText(player_hand.get(x)+" Pizzeria");
                break;
            case 30:
                
               etykiety.get(x).setText(player_hand.get(x)+" Zarządzanie");
                break;
            case 32:
                
                etykiety.get(x).setText(player_hand.get(x)+" Wzornictwo");
                break;
            case 33:
                
               etykiety.get(x).setText(player_hand.get(x)+" Sztuka i media");
                break;
            case 35:
                
                etykiety.get(x).setText(player_hand.get(x)+" Malarstwo");
                break;
            case 36:
                
                etykiety.get(x).setText(player_hand.get(x)+" MZK Koszalin E");
                break;
            case 38:
                
                etykiety.get(x).setText(player_hand.get(x)+" Elektronika i telekomunikacja");
                break;
            case 40:
                
               etykiety.get(x).setText(player_hand.get(x)+" Informatyka");
                break;
           
        }
            
            etykiety.get(x).setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(player_hand.get(x)+".png")+"\">");
        }
    }
    
    public Player_Hand() {
        initComponents();
        etykiety.add(jLabel1);
        etykiety.add(jLabel2);
        etykiety.add(jLabel3);
        etykiety.add(jLabel4);
        etykiety.add(jLabel5);
        etykiety.add(jLabel6);
        etykiety.add(jLabel7);
        etykiety.add(jLabel8);
        etykiety.add(jLabel9);
        etykiety.add(jLabel10);
        etykiety.add(jLabel11);
        etykiety.add(jLabel12);
        etykiety.add(jLabel13);
        etykiety.add(jLabel14);
        etykiety.add(jLabel15);
        etykiety.add(jLabel16);
        etykiety.add(jLabel17);
        etykiety.add(jLabel18);
        etykiety.add(jLabel19);
        etykiety.add(jLabel20);
        
        
        
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        jLabel5 = new javax.swing.JLabel();
        jLabel6 = new javax.swing.JLabel();
        jLabel7 = new javax.swing.JLabel();
        jLabel8 = new javax.swing.JLabel();
        jLabel9 = new javax.swing.JLabel();
        jLabel10 = new javax.swing.JLabel();
        jLabel11 = new javax.swing.JLabel();
        jLabel12 = new javax.swing.JLabel();
        jLabel13 = new javax.swing.JLabel();
        jLabel14 = new javax.swing.JLabel();
        jLabel15 = new javax.swing.JLabel();
        jLabel16 = new javax.swing.JLabel();
        jLabel17 = new javax.swing.JLabel();
        jLabel18 = new javax.swing.JLabel();
        jLabel19 = new javax.swing.JLabel();
        jLabel20 = new javax.swing.JLabel();

        jLabel1.setPreferredSize(new java.awt.Dimension(250, 25));

        jLabel2.setPreferredSize(new java.awt.Dimension(250, 25));

        jLabel3.setPreferredSize(new java.awt.Dimension(250, 25));

        jLabel4.setPreferredSize(new java.awt.Dimension(250, 25));

        jLabel5.setPreferredSize(new java.awt.Dimension(250, 25));

        jLabel6.setPreferredSize(new java.awt.Dimension(250, 25));

        jLabel7.setPreferredSize(new java.awt.Dimension(250, 25));

        jLabel8.setPreferredSize(new java.awt.Dimension(250, 25));

        jLabel9.setPreferredSize(new java.awt.Dimension(250, 25));

        jLabel10.setPreferredSize(new java.awt.Dimension(250, 25));

        jLabel11.setPreferredSize(new java.awt.Dimension(250, 25));

        jLabel12.setPreferredSize(new java.awt.Dimension(250, 25));

        jLabel13.setPreferredSize(new java.awt.Dimension(250, 25));

        jLabel14.setPreferredSize(new java.awt.Dimension(250, 25));

        jLabel15.setPreferredSize(new java.awt.Dimension(250, 25));

        jLabel16.setPreferredSize(new java.awt.Dimension(250, 25));

        jLabel17.setPreferredSize(new java.awt.Dimension(250, 25));

        jLabel18.setPreferredSize(new java.awt.Dimension(250, 25));

        jLabel19.setPreferredSize(new java.awt.Dimension(250, 25));

        jLabel20.setPreferredSize(new java.awt.Dimension(250, 25));

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(this);
        this.setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel5, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel7, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel9, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel20, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel12, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel14, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel16, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel18, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED, 38, Short.MAX_VALUE)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel4, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel6, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel8, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel10, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel11, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel13, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel15, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel17, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel19, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap())
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addGap(23, 23, 23)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel4, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel5, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel6, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel8, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel7, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel9, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel10, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel20, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel11, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel12, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel13, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel14, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel15, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel17, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel16, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jLabel18, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jLabel19, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
    }// </editor-fold>//GEN-END:initComponents


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel10;
    private javax.swing.JLabel jLabel11;
    private javax.swing.JLabel jLabel12;
    private javax.swing.JLabel jLabel13;
    private javax.swing.JLabel jLabel14;
    private javax.swing.JLabel jLabel15;
    private javax.swing.JLabel jLabel16;
    private javax.swing.JLabel jLabel17;
    private javax.swing.JLabel jLabel18;
    private javax.swing.JLabel jLabel19;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel20;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JLabel jLabel9;
    // End of variables declaration//GEN-END:variables
}
