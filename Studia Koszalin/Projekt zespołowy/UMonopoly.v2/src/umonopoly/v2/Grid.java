/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package umonopoly.v2;

import java.util.Vector;
import javax.swing.ImageIcon;
import javax.swing.JLabel;

/**
 *
 * @author Oskar
 */
public class Grid extends javax.swing.JComponent {

     private Vector<JLabel> czerwony = new Vector<>();
     private Vector<JLabel> zielony = new Vector<>();
     private Vector<JLabel> niebieski = new Vector<>();
     private Vector<JLabel> zolty = new Vector<>();
    
     public void clean()
     {
         for(int x=0;x<czerwony.size();x++)
         {
             czerwony.get(x).setIcon(null);
             zielony.get(x).setIcon(null);
             niebieski.get(x).setIcon(null);
             zolty.get(x).setIcon(null);
         }
     }
     
     public void rysujR(int x)
     {
          for(int z=0;z<czerwony.size();z++)
         {
             czerwony.get(z).setIcon(null);
         }
          
         czerwony.get(x).setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png")));
     }
     
     public void rysujG(int x)
     {
          for(int z=0;z<zielony.size();z++)
         {
             zielony.get(z).setIcon(null);
         }
          
         zielony.get(x).setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png")));
     }
     
     public void rysujB(int x)
     {
          for(int z=0;z<niebieski.size();z++)
         {
             niebieski.get(z).setIcon(null);
         }
          
         niebieski.get(x).setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png")));
     }
     
     public void rysujY(int x)
     {
          for(int z=0;z<zolty.size();z++)
         {
             zolty.get(z).setIcon(null);
         }
          
         zolty.get(x).setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png")));
     }
     
     public Grid() {
        initComponents();
        czerwony.add(jLabel27);
        czerwony.add(jLabel7);
        czerwony.add(jLabel8);
        czerwony.add(jLabel2);
        czerwony.add(jLabel10);
        czerwony.add(jLabel11);
        czerwony.add(jLabel12);
        czerwony.add(jLabel15);
        czerwony.add(jLabel14);
        czerwony.add(jLabel13);
        czerwony.add(jLabel9);
        czerwony.add(jLabel44);
        czerwony.add(jLabel43);
        czerwony.add(jLabel42);
        czerwony.add(jLabel41);
        czerwony.add(jLabel40);
        czerwony.add(jLabel39);
        czerwony.add(jLabel38);
        czerwony.add(jLabel37);
        czerwony.add(jLabel36);
        czerwony.add(jLabel26);
        czerwony.add(jLabel25);
        czerwony.add(jLabel24);
        czerwony.add(jLabel23);
        czerwony.add(jLabel22);
        czerwony.add(jLabel21);
        czerwony.add(jLabel20);
        czerwony.add(jLabel19);
        czerwony.add(jLabel18);
        czerwony.add(jLabel17);
        czerwony.add(jLabel16);
        czerwony.add(jLabel34);
        czerwony.add(jLabel35);
        czerwony.add(jLabel33);
        czerwony.add(jLabel32);
        czerwony.add(jLabel31);
        czerwony.add(jLabel30);
        czerwony.add(jLabel29);
        czerwony.add(jLabel28);
        czerwony.add(jLabel6);
        
        niebieski.add(jLabel66);
        niebieski.add(jLabel46);
        niebieski.add(jLabel47);
        niebieski.add(jLabel3);
        niebieski.add(jLabel49);
        niebieski.add(jLabel50);
        niebieski.add(jLabel51);
        niebieski.add(jLabel54);
        niebieski.add(jLabel53);
        niebieski.add(jLabel52);
        niebieski.add(jLabel48);
        niebieski.add(jLabel83);
        niebieski.add(jLabel82);
        niebieski.add(jLabel81);
        niebieski.add(jLabel80);
        niebieski.add(jLabel79);
        niebieski.add(jLabel78);
        niebieski.add(jLabel77);
        niebieski.add(jLabel76);
        niebieski.add(jLabel75);
        niebieski.add(jLabel65);
        niebieski.add(jLabel64);
        niebieski.add(jLabel63);
        niebieski.add(jLabel62);
        niebieski.add(jLabel61);
        niebieski.add(jLabel60);
        niebieski.add(jLabel59);
        niebieski.add(jLabel58);
        niebieski.add(jLabel57);
        niebieski.add(jLabel56);
        niebieski.add(jLabel55);
        niebieski.add(jLabel73);
        niebieski.add(jLabel74);
        niebieski.add(jLabel72);
        niebieski.add(jLabel71);
        niebieski.add(jLabel70);
        niebieski.add(jLabel69);
        niebieski.add(jLabel68);
        niebieski.add(jLabel67);
        niebieski.add(jLabel45);
       
        
        zielony.add(g1);
        zielony.add(g2);
        zielony.add(g3);
        zielony.add(g4);
        zielony.add(g5);
        zielony.add(g6);
        zielony.add(g7);
        zielony.add(g8);
        zielony.add(g9);
        zielony.add(g10);
        zielony.add(g11);
        zielony.add(g12);
        zielony.add(g13);
        zielony.add(g14);
        zielony.add(g15);
        zielony.add(g16);
        zielony.add(g17);
        zielony.add(g18);
        zielony.add(g19);
        zielony.add(g20);
        zielony.add(g21);
        zielony.add(g22);
        zielony.add(g23);
        zielony.add(g24);
        zielony.add(g25);
        zielony.add(g26);
        zielony.add(g27);
        zielony.add(g28);
        zielony.add(g29);
        zielony.add(g30);
        zielony.add(g31);
        zielony.add(g32);
        zielony.add(g33);
        zielony.add(g34);
        zielony.add(g35);
        zielony.add(g36);
        zielony.add(g37);
        zielony.add(g38);
        zielony.add(g39);
        zielony.add(g40);
        
        zolty.add(g41);
        zolty.add(g42);
        zolty.add(g43);
        zolty.add(g44);
        zolty.add(g45);
        zolty.add(g46);
        zolty.add(g47);
        zolty.add(g48);
        zolty.add(g49);
        zolty.add(g50);
        zolty.add(g51);
        zolty.add(g52);
        zolty.add(g53);
        zolty.add(g54);
        zolty.add(g55);
        zolty.add(g56);
        zolty.add(g57);
        zolty.add(g58);
        zolty.add(g59);
        zolty.add(g60);
        zolty.add(g61);
        zolty.add(g62);
        zolty.add(g63);
        zolty.add(g64);
        zolty.add(g65);
        zolty.add(g66);
        zolty.add(g67);
        zolty.add(g68);
        zolty.add(g69);
        zolty.add(g70);
        zolty.add(g71);
        zolty.add(g72);
        zolty.add(g73);
        zolty.add(g74);
        zolty.add(g75);
        zolty.add(g76);
        zolty.add(g77);
        zolty.add(g78);
        zolty.add(g79);
        zolty.add(g80);
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        g1 = new javax.swing.JLabel();
        g2 = new javax.swing.JLabel();
        g3 = new javax.swing.JLabel();
        g4 = new javax.swing.JLabel();
        g5 = new javax.swing.JLabel();
        g6 = new javax.swing.JLabel();
        g7 = new javax.swing.JLabel();
        g8 = new javax.swing.JLabel();
        g9 = new javax.swing.JLabel();
        g10 = new javax.swing.JLabel();
        g11 = new javax.swing.JLabel();
        g12 = new javax.swing.JLabel();
        g13 = new javax.swing.JLabel();
        g14 = new javax.swing.JLabel();
        g15 = new javax.swing.JLabel();
        g16 = new javax.swing.JLabel();
        g17 = new javax.swing.JLabel();
        g18 = new javax.swing.JLabel();
        g19 = new javax.swing.JLabel();
        g20 = new javax.swing.JLabel();
        g21 = new javax.swing.JLabel();
        g22 = new javax.swing.JLabel();
        g23 = new javax.swing.JLabel();
        g24 = new javax.swing.JLabel();
        g25 = new javax.swing.JLabel();
        g26 = new javax.swing.JLabel();
        g27 = new javax.swing.JLabel();
        g28 = new javax.swing.JLabel();
        g29 = new javax.swing.JLabel();
        g30 = new javax.swing.JLabel();
        g31 = new javax.swing.JLabel();
        g32 = new javax.swing.JLabel();
        g33 = new javax.swing.JLabel();
        g34 = new javax.swing.JLabel();
        g35 = new javax.swing.JLabel();
        g36 = new javax.swing.JLabel();
        g37 = new javax.swing.JLabel();
        g38 = new javax.swing.JLabel();
        g39 = new javax.swing.JLabel();
        g40 = new javax.swing.JLabel();
        g41 = new javax.swing.JLabel();
        g42 = new javax.swing.JLabel();
        g43 = new javax.swing.JLabel();
        g44 = new javax.swing.JLabel();
        g45 = new javax.swing.JLabel();
        g46 = new javax.swing.JLabel();
        g47 = new javax.swing.JLabel();
        g48 = new javax.swing.JLabel();
        g49 = new javax.swing.JLabel();
        g50 = new javax.swing.JLabel();
        g51 = new javax.swing.JLabel();
        g52 = new javax.swing.JLabel();
        g53 = new javax.swing.JLabel();
        g54 = new javax.swing.JLabel();
        g55 = new javax.swing.JLabel();
        g56 = new javax.swing.JLabel();
        g57 = new javax.swing.JLabel();
        g58 = new javax.swing.JLabel();
        g59 = new javax.swing.JLabel();
        g60 = new javax.swing.JLabel();
        g61 = new javax.swing.JLabel();
        g62 = new javax.swing.JLabel();
        g63 = new javax.swing.JLabel();
        g64 = new javax.swing.JLabel();
        g65 = new javax.swing.JLabel();
        g66 = new javax.swing.JLabel();
        g67 = new javax.swing.JLabel();
        g68 = new javax.swing.JLabel();
        g69 = new javax.swing.JLabel();
        g70 = new javax.swing.JLabel();
        g71 = new javax.swing.JLabel();
        g72 = new javax.swing.JLabel();
        g73 = new javax.swing.JLabel();
        g74 = new javax.swing.JLabel();
        g75 = new javax.swing.JLabel();
        g76 = new javax.swing.JLabel();
        g77 = new javax.swing.JLabel();
        g78 = new javax.swing.JLabel();
        g79 = new javax.swing.JLabel();
        g80 = new javax.swing.JLabel();
        jLabel17 = new javax.swing.JLabel();
        jLabel18 = new javax.swing.JLabel();
        jLabel19 = new javax.swing.JLabel();
        jLabel20 = new javax.swing.JLabel();
        jLabel21 = new javax.swing.JLabel();
        jLabel22 = new javax.swing.JLabel();
        jLabel23 = new javax.swing.JLabel();
        jLabel24 = new javax.swing.JLabel();
        jLabel25 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jLabel45 = new javax.swing.JLabel();
        jLabel46 = new javax.swing.JLabel();
        jLabel47 = new javax.swing.JLabel();
        jLabel48 = new javax.swing.JLabel();
        jLabel49 = new javax.swing.JLabel();
        jLabel50 = new javax.swing.JLabel();
        jLabel51 = new javax.swing.JLabel();
        jLabel52 = new javax.swing.JLabel();
        jLabel53 = new javax.swing.JLabel();
        jLabel54 = new javax.swing.JLabel();
        jLabel55 = new javax.swing.JLabel();
        jLabel56 = new javax.swing.JLabel();
        jLabel57 = new javax.swing.JLabel();
        jLabel58 = new javax.swing.JLabel();
        jLabel59 = new javax.swing.JLabel();
        jLabel60 = new javax.swing.JLabel();
        jLabel61 = new javax.swing.JLabel();
        jLabel62 = new javax.swing.JLabel();
        jLabel63 = new javax.swing.JLabel();
        jLabel64 = new javax.swing.JLabel();
        jLabel65 = new javax.swing.JLabel();
        jLabel66 = new javax.swing.JLabel();
        jLabel67 = new javax.swing.JLabel();
        jLabel68 = new javax.swing.JLabel();
        jLabel69 = new javax.swing.JLabel();
        jLabel70 = new javax.swing.JLabel();
        jLabel71 = new javax.swing.JLabel();
        jLabel72 = new javax.swing.JLabel();
        jLabel73 = new javax.swing.JLabel();
        jLabel74 = new javax.swing.JLabel();
        jLabel75 = new javax.swing.JLabel();
        jLabel76 = new javax.swing.JLabel();
        jLabel77 = new javax.swing.JLabel();
        jLabel78 = new javax.swing.JLabel();
        jLabel79 = new javax.swing.JLabel();
        jLabel80 = new javax.swing.JLabel();
        jLabel81 = new javax.swing.JLabel();
        jLabel82 = new javax.swing.JLabel();
        jLabel83 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
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
        jLabel26 = new javax.swing.JLabel();
        jLabel27 = new javax.swing.JLabel();
        jLabel28 = new javax.swing.JLabel();
        jLabel29 = new javax.swing.JLabel();
        jLabel30 = new javax.swing.JLabel();
        jLabel31 = new javax.swing.JLabel();
        jLabel32 = new javax.swing.JLabel();
        jLabel33 = new javax.swing.JLabel();
        jLabel34 = new javax.swing.JLabel();
        jLabel35 = new javax.swing.JLabel();
        jLabel36 = new javax.swing.JLabel();
        jLabel37 = new javax.swing.JLabel();
        jLabel38 = new javax.swing.JLabel();
        jLabel39 = new javax.swing.JLabel();
        jLabel40 = new javax.swing.JLabel();
        jLabel41 = new javax.swing.JLabel();
        jLabel42 = new javax.swing.JLabel();
        jLabel43 = new javax.swing.JLabel();
        jLabel44 = new javax.swing.JLabel();
        jLabel1 = new javax.swing.JLabel();

        setPreferredSize(new java.awt.Dimension(701, 733));
        setLayout(new org.netbeans.lib.awtextra.AbsoluteLayout());

        g1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g1, new org.netbeans.lib.awtextra.AbsoluteConstraints(640, 660, -1, -1));

        g2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g2, new org.netbeans.lib.awtextra.AbsoluteConstraints(590, 660, -1, -1));

        g3.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g3, new org.netbeans.lib.awtextra.AbsoluteConstraints(530, 650, -1, -1));

        g4.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g4, new org.netbeans.lib.awtextra.AbsoluteConstraints(480, 670, -1, -1));

        g5.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g5, new org.netbeans.lib.awtextra.AbsoluteConstraints(410, 650, -1, -1));

        g6.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g6, new org.netbeans.lib.awtextra.AbsoluteConstraints(360, 650, -1, -1));

        g7.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g7, new org.netbeans.lib.awtextra.AbsoluteConstraints(310, 660, -1, -1));

        g8.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g8, new org.netbeans.lib.awtextra.AbsoluteConstraints(250, 650, -1, -1));

        g9.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g9, new org.netbeans.lib.awtextra.AbsoluteConstraints(190, 660, -1, -1));

        g10.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g10, new org.netbeans.lib.awtextra.AbsoluteConstraints(120, 650, -1, -1));

        g11.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g11, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 610, -1, -1));

        g12.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g12, new org.netbeans.lib.awtextra.AbsoluteConstraints(30, 560, -1, -1));

        g13.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g13, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 500, -1, -1));

        g14.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g14, new org.netbeans.lib.awtextra.AbsoluteConstraints(30, 450, -1, -1));

        g15.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g15, new org.netbeans.lib.awtextra.AbsoluteConstraints(30, 390, -1, -1));

        g16.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g16, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 340, -1, -1));

        g17.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g17, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 280, -1, -1));

        g18.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g18, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 220, -1, -1));

        g19.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g19, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 170, -1, -1));

        g20.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g20, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 110, -1, -1));

        g21.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g21, new org.netbeans.lib.awtextra.AbsoluteConstraints(60, 10, -1, -1));

        g22.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g22, new org.netbeans.lib.awtextra.AbsoluteConstraints(110, 10, -1, -1));

        g23.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g23, new org.netbeans.lib.awtextra.AbsoluteConstraints(190, 10, 50, -1));

        g24.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g24, new org.netbeans.lib.awtextra.AbsoluteConstraints(230, 10, -1, -1));

        g25.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g25, new org.netbeans.lib.awtextra.AbsoluteConstraints(290, 10, -1, -1));

        g26.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g26, new org.netbeans.lib.awtextra.AbsoluteConstraints(340, 0, -1, -1));

        g27.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g27, new org.netbeans.lib.awtextra.AbsoluteConstraints(400, 0, -1, -1));

        g28.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g28, new org.netbeans.lib.awtextra.AbsoluteConstraints(460, 0, -1, -1));

        g29.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g29, new org.netbeans.lib.awtextra.AbsoluteConstraints(510, 10, -1, -1));

        g30.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g30, new org.netbeans.lib.awtextra.AbsoluteConstraints(570, 10, -1, -1));

        g31.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g31, new org.netbeans.lib.awtextra.AbsoluteConstraints(650, 10, -1, -1));

        g32.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g32, new org.netbeans.lib.awtextra.AbsoluteConstraints(660, 110, -1, -1));

        g33.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g33, new org.netbeans.lib.awtextra.AbsoluteConstraints(660, 170, -1, -1));

        g34.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g34, new org.netbeans.lib.awtextra.AbsoluteConstraints(680, 230, -1, -1));

        g35.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g35, new org.netbeans.lib.awtextra.AbsoluteConstraints(660, 280, -1, -1));

        g36.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g36, new org.netbeans.lib.awtextra.AbsoluteConstraints(660, 340, -1, -1));

        g37.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g37, new org.netbeans.lib.awtextra.AbsoluteConstraints(650, 390, -1, -1));

        g38.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g38, new org.netbeans.lib.awtextra.AbsoluteConstraints(640, 440, -1, -1));

        g39.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g39, new org.netbeans.lib.awtextra.AbsoluteConstraints(650, 500, -1, -1));

        g40.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek green.png"))); // NOI18N
        add(g40, new org.netbeans.lib.awtextra.AbsoluteConstraints(660, 560, -1, -1));

        g41.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g41, new org.netbeans.lib.awtextra.AbsoluteConstraints(680, 660, -1, -1));

        g42.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g42, new org.netbeans.lib.awtextra.AbsoluteConstraints(570, 660, -1, 50));

        g43.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g43, new org.netbeans.lib.awtextra.AbsoluteConstraints(520, 660, -1, -1));

        g44.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g44, new org.netbeans.lib.awtextra.AbsoluteConstraints(460, 670, -1, -1));

        g45.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g45, new org.netbeans.lib.awtextra.AbsoluteConstraints(420, 660, -1, -1));

        g46.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g46, new org.netbeans.lib.awtextra.AbsoluteConstraints(340, 660, -1, -1));

        g47.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g47, new org.netbeans.lib.awtextra.AbsoluteConstraints(290, 660, -1, -1));

        g48.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g48, new org.netbeans.lib.awtextra.AbsoluteConstraints(240, 650, -1, -1));

        g49.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g49, new org.netbeans.lib.awtextra.AbsoluteConstraints(170, 660, -1, -1));

        g50.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g50, new org.netbeans.lib.awtextra.AbsoluteConstraints(140, 650, -1, -1));

        g51.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g51, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 660, -1, -1));

        g52.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g52, new org.netbeans.lib.awtextra.AbsoluteConstraints(70, 560, -1, -1));

        g53.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g53, new org.netbeans.lib.awtextra.AbsoluteConstraints(70, 500, -1, -1));

        g54.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g54, new org.netbeans.lib.awtextra.AbsoluteConstraints(70, 450, -1, -1));

        g55.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g55, new org.netbeans.lib.awtextra.AbsoluteConstraints(70, 390, -1, -1));

        g56.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g56, new org.netbeans.lib.awtextra.AbsoluteConstraints(60, 340, -1, -1));

        g57.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g57, new org.netbeans.lib.awtextra.AbsoluteConstraints(60, 280, -1, -1));

        g58.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g58, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 220, -1, -1));

        g59.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g59, new org.netbeans.lib.awtextra.AbsoluteConstraints(60, 170, -1, -1));

        g60.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g60, new org.netbeans.lib.awtextra.AbsoluteConstraints(60, 110, -1, -1));

        g61.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g61, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 10, -1, -1));

        g62.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g62, new org.netbeans.lib.awtextra.AbsoluteConstraints(130, 40, -1, -1));

        g63.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g63, new org.netbeans.lib.awtextra.AbsoluteConstraints(190, 60, 50, -1));

        g64.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g64, new org.netbeans.lib.awtextra.AbsoluteConstraints(250, 40, -1, -1));

        g65.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g65, new org.netbeans.lib.awtextra.AbsoluteConstraints(310, 30, -1, -1));

        g66.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g66, new org.netbeans.lib.awtextra.AbsoluteConstraints(360, 30, -1, -1));

        g67.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g67, new org.netbeans.lib.awtextra.AbsoluteConstraints(430, 30, -1, -1));

        g68.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g68, new org.netbeans.lib.awtextra.AbsoluteConstraints(480, 30, -1, -1));

        g69.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g69, new org.netbeans.lib.awtextra.AbsoluteConstraints(540, 40, -1, -1));

        g70.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g70, new org.netbeans.lib.awtextra.AbsoluteConstraints(600, 30, -1, -1));

        g71.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g71, new org.netbeans.lib.awtextra.AbsoluteConstraints(690, 10, -1, -1));

        g72.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g72, new org.netbeans.lib.awtextra.AbsoluteConstraints(700, 120, -1, -1));

        g73.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g73, new org.netbeans.lib.awtextra.AbsoluteConstraints(700, 170, -1, -1));

        g74.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g74, new org.netbeans.lib.awtextra.AbsoluteConstraints(700, 230, -1, -1));

        g75.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g75, new org.netbeans.lib.awtextra.AbsoluteConstraints(700, 280, -1, -1));

        g76.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g76, new org.netbeans.lib.awtextra.AbsoluteConstraints(700, 340, -1, -1));

        g77.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g77, new org.netbeans.lib.awtextra.AbsoluteConstraints(700, 390, -1, -1));

        g78.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g78, new org.netbeans.lib.awtextra.AbsoluteConstraints(690, 440, -1, -1));

        g79.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g79, new org.netbeans.lib.awtextra.AbsoluteConstraints(690, 500, -1, -1));

        g80.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek yellow.png"))); // NOI18N
        add(g80, new org.netbeans.lib.awtextra.AbsoluteConstraints(700, 560, -1, -1));

        jLabel17.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel17, new org.netbeans.lib.awtextra.AbsoluteConstraints(580, 40, -1, -1));

        jLabel18.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel18, new org.netbeans.lib.awtextra.AbsoluteConstraints(520, 40, -1, -1));

        jLabel19.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel19, new org.netbeans.lib.awtextra.AbsoluteConstraints(460, 30, -1, -1));

        jLabel20.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel20, new org.netbeans.lib.awtextra.AbsoluteConstraints(410, 30, -1, -1));

        jLabel21.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel21, new org.netbeans.lib.awtextra.AbsoluteConstraints(340, 30, -1, -1));

        jLabel22.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel22, new org.netbeans.lib.awtextra.AbsoluteConstraints(290, 30, -1, -1));

        jLabel23.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel23, new org.netbeans.lib.awtextra.AbsoluteConstraints(230, 40, -1, -1));

        jLabel24.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel24, new org.netbeans.lib.awtextra.AbsoluteConstraints(170, 60, 50, -1));

        jLabel25.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel25, new org.netbeans.lib.awtextra.AbsoluteConstraints(120, 40, -1, -1));

        jLabel3.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel3, new org.netbeans.lib.awtextra.AbsoluteConstraints(460, 650, -1, -1));

        jLabel45.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel45, new org.netbeans.lib.awtextra.AbsoluteConstraints(680, 560, -1, -1));

        jLabel46.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel46, new org.netbeans.lib.awtextra.AbsoluteConstraints(570, 640, -1, 50));

        jLabel47.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel47, new org.netbeans.lib.awtextra.AbsoluteConstraints(520, 630, -1, -1));

        jLabel48.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel48, new org.netbeans.lib.awtextra.AbsoluteConstraints(60, 660, -1, -1));

        jLabel49.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel49, new org.netbeans.lib.awtextra.AbsoluteConstraints(410, 630, -1, -1));

        jLabel50.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel50, new org.netbeans.lib.awtextra.AbsoluteConstraints(350, 630, -1, -1));

        jLabel51.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel51, new org.netbeans.lib.awtextra.AbsoluteConstraints(310, 630, -1, -1));

        jLabel52.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel52, new org.netbeans.lib.awtextra.AbsoluteConstraints(130, 630, -1, -1));

        jLabel53.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel53, new org.netbeans.lib.awtextra.AbsoluteConstraints(170, 630, -1, -1));

        jLabel54.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel54, new org.netbeans.lib.awtextra.AbsoluteConstraints(240, 630, -1, -1));

        jLabel55.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel55, new org.netbeans.lib.awtextra.AbsoluteConstraints(690, 50, -1, -1));

        jLabel56.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel56, new org.netbeans.lib.awtextra.AbsoluteConstraints(590, 10, -1, -1));

        jLabel57.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel57, new org.netbeans.lib.awtextra.AbsoluteConstraints(530, 10, -1, -1));

        jLabel58.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel58, new org.netbeans.lib.awtextra.AbsoluteConstraints(480, 0, -1, -1));

        jLabel59.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel59, new org.netbeans.lib.awtextra.AbsoluteConstraints(430, 0, -1, -1));

        jLabel60.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel60, new org.netbeans.lib.awtextra.AbsoluteConstraints(360, 10, -1, -1));

        jLabel61.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel61, new org.netbeans.lib.awtextra.AbsoluteConstraints(310, 10, -1, -1));

        jLabel62.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel62, new org.netbeans.lib.awtextra.AbsoluteConstraints(250, 10, -1, -1));

        jLabel63.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel63, new org.netbeans.lib.awtextra.AbsoluteConstraints(170, 10, -1, -1));

        jLabel64.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel64, new org.netbeans.lib.awtextra.AbsoluteConstraints(130, 10, -1, -1));

        jLabel65.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel65, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 60, -1, -1));

        jLabel66.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel66, new org.netbeans.lib.awtextra.AbsoluteConstraints(680, 620, -1, -1));

        jLabel67.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel67, new org.netbeans.lib.awtextra.AbsoluteConstraints(670, 500, -1, -1));

        jLabel68.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel68, new org.netbeans.lib.awtextra.AbsoluteConstraints(660, 440, -1, -1));

        jLabel69.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel69, new org.netbeans.lib.awtextra.AbsoluteConstraints(670, 390, -1, -1));

        jLabel70.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel70, new org.netbeans.lib.awtextra.AbsoluteConstraints(680, 340, -1, -1));

        jLabel71.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel71, new org.netbeans.lib.awtextra.AbsoluteConstraints(680, 280, -1, -1));

        jLabel72.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel72, new org.netbeans.lib.awtextra.AbsoluteConstraints(660, 230, -1, -1));

        jLabel73.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel73, new org.netbeans.lib.awtextra.AbsoluteConstraints(680, 120, -1, -1));

        jLabel74.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel74, new org.netbeans.lib.awtextra.AbsoluteConstraints(680, 170, 30, -1));

        jLabel75.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel75, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 110, -1, -1));

        jLabel76.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel76, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 170, -1, -1));

        jLabel77.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel77, new org.netbeans.lib.awtextra.AbsoluteConstraints(20, 220, -1, -1));

        jLabel78.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel78, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 280, -1, -1));

        jLabel79.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel79, new org.netbeans.lib.awtextra.AbsoluteConstraints(0, 340, -1, -1));

        jLabel80.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel80, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 390, -1, -1));

        jLabel81.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel81, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 450, -1, -1));

        jLabel82.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel82, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 500, -1, -1));

        jLabel83.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/Niebieski2.png"))); // NOI18N
        add(jLabel83, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, 560, -1, -1));

        jLabel2.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel2, new org.netbeans.lib.awtextra.AbsoluteConstraints(460, 630, -1, -1));

        jLabel6.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel6, new org.netbeans.lib.awtextra.AbsoluteConstraints(640, 560, -1, -1));

        jLabel7.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel7, new org.netbeans.lib.awtextra.AbsoluteConstraints(580, 630, -1, -1));

        jLabel8.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel8, new org.netbeans.lib.awtextra.AbsoluteConstraints(520, 610, -1, -1));

        jLabel9.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel9, new org.netbeans.lib.awtextra.AbsoluteConstraints(60, 610, -1, -1));

        jLabel10.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel10, new org.netbeans.lib.awtextra.AbsoluteConstraints(410, 610, -1, -1));

        jLabel11.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel11, new org.netbeans.lib.awtextra.AbsoluteConstraints(360, 610, -1, -1));

        jLabel12.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel12, new org.netbeans.lib.awtextra.AbsoluteConstraints(290, 610, -1, -1));

        jLabel13.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel13, new org.netbeans.lib.awtextra.AbsoluteConstraints(120, 620, -1, -1));

        jLabel14.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel14, new org.netbeans.lib.awtextra.AbsoluteConstraints(190, 630, -1, -1));

        jLabel15.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel15, new org.netbeans.lib.awtextra.AbsoluteConstraints(240, 610, -1, -1));

        jLabel16.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel16, new org.netbeans.lib.awtextra.AbsoluteConstraints(650, 50, -1, -1));

        jLabel26.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel26, new org.netbeans.lib.awtextra.AbsoluteConstraints(60, 60, -1, -1));

        jLabel27.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel27, new org.netbeans.lib.awtextra.AbsoluteConstraints(640, 620, -1, -1));

        jLabel28.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel28, new org.netbeans.lib.awtextra.AbsoluteConstraints(630, 500, -1, -1));

        jLabel29.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel29, new org.netbeans.lib.awtextra.AbsoluteConstraints(630, 440, -1, -1));

        jLabel30.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel30, new org.netbeans.lib.awtextra.AbsoluteConstraints(630, 390, -1, -1));

        jLabel31.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel31, new org.netbeans.lib.awtextra.AbsoluteConstraints(640, 340, -1, -1));

        jLabel32.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel32, new org.netbeans.lib.awtextra.AbsoluteConstraints(640, 280, -1, -1));

        jLabel33.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel33, new org.netbeans.lib.awtextra.AbsoluteConstraints(640, 230, -1, -1));

        jLabel34.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel34, new org.netbeans.lib.awtextra.AbsoluteConstraints(640, 110, -1, -1));

        jLabel35.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel35, new org.netbeans.lib.awtextra.AbsoluteConstraints(640, 170, -1, -1));

        jLabel36.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel36, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 110, -1, -1));

        jLabel37.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel37, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 170, -1, -1));

        jLabel38.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel38, new org.netbeans.lib.awtextra.AbsoluteConstraints(60, 220, -1, -1));

        jLabel39.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel39, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 280, -1, -1));

        jLabel40.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel40, new org.netbeans.lib.awtextra.AbsoluteConstraints(40, 340, -1, -1));

        jLabel41.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel41, new org.netbeans.lib.awtextra.AbsoluteConstraints(50, 390, -1, -1));

        jLabel42.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel42, new org.netbeans.lib.awtextra.AbsoluteConstraints(50, 450, -1, -1));

        jLabel43.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel43, new org.netbeans.lib.awtextra.AbsoluteConstraints(50, 500, -1, -1));

        jLabel44.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/pionek red.png"))); // NOI18N
        add(jLabel44, new org.netbeans.lib.awtextra.AbsoluteConstraints(50, 560, -1, -1));

        jLabel1.setIcon(new javax.swing.ImageIcon(getClass().getResource("/umonopoly/v2/monopoly.png"))); // NOI18N
        add(jLabel1, new org.netbeans.lib.awtextra.AbsoluteConstraints(10, -20, 730, 760));
    }// </editor-fold>//GEN-END:initComponents


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel g1;
    private javax.swing.JLabel g10;
    private javax.swing.JLabel g11;
    private javax.swing.JLabel g12;
    private javax.swing.JLabel g13;
    private javax.swing.JLabel g14;
    private javax.swing.JLabel g15;
    private javax.swing.JLabel g16;
    private javax.swing.JLabel g17;
    private javax.swing.JLabel g18;
    private javax.swing.JLabel g19;
    private javax.swing.JLabel g2;
    private javax.swing.JLabel g20;
    private javax.swing.JLabel g21;
    private javax.swing.JLabel g22;
    private javax.swing.JLabel g23;
    private javax.swing.JLabel g24;
    private javax.swing.JLabel g25;
    private javax.swing.JLabel g26;
    private javax.swing.JLabel g27;
    private javax.swing.JLabel g28;
    private javax.swing.JLabel g29;
    private javax.swing.JLabel g3;
    private javax.swing.JLabel g30;
    private javax.swing.JLabel g31;
    private javax.swing.JLabel g32;
    private javax.swing.JLabel g33;
    private javax.swing.JLabel g34;
    private javax.swing.JLabel g35;
    private javax.swing.JLabel g36;
    private javax.swing.JLabel g37;
    private javax.swing.JLabel g38;
    private javax.swing.JLabel g39;
    private javax.swing.JLabel g4;
    private javax.swing.JLabel g40;
    private javax.swing.JLabel g41;
    private javax.swing.JLabel g42;
    private javax.swing.JLabel g43;
    private javax.swing.JLabel g44;
    private javax.swing.JLabel g45;
    private javax.swing.JLabel g46;
    private javax.swing.JLabel g47;
    private javax.swing.JLabel g48;
    private javax.swing.JLabel g49;
    private javax.swing.JLabel g5;
    private javax.swing.JLabel g50;
    private javax.swing.JLabel g51;
    private javax.swing.JLabel g52;
    private javax.swing.JLabel g53;
    private javax.swing.JLabel g54;
    private javax.swing.JLabel g55;
    private javax.swing.JLabel g56;
    private javax.swing.JLabel g57;
    private javax.swing.JLabel g58;
    private javax.swing.JLabel g59;
    private javax.swing.JLabel g6;
    private javax.swing.JLabel g60;
    private javax.swing.JLabel g61;
    private javax.swing.JLabel g62;
    private javax.swing.JLabel g63;
    private javax.swing.JLabel g64;
    private javax.swing.JLabel g65;
    private javax.swing.JLabel g66;
    private javax.swing.JLabel g67;
    private javax.swing.JLabel g68;
    private javax.swing.JLabel g69;
    private javax.swing.JLabel g7;
    private javax.swing.JLabel g70;
    private javax.swing.JLabel g71;
    private javax.swing.JLabel g72;
    private javax.swing.JLabel g73;
    private javax.swing.JLabel g74;
    private javax.swing.JLabel g75;
    private javax.swing.JLabel g76;
    private javax.swing.JLabel g77;
    private javax.swing.JLabel g78;
    private javax.swing.JLabel g79;
    private javax.swing.JLabel g8;
    private javax.swing.JLabel g80;
    private javax.swing.JLabel g9;
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
    private javax.swing.JLabel jLabel21;
    private javax.swing.JLabel jLabel22;
    private javax.swing.JLabel jLabel23;
    private javax.swing.JLabel jLabel24;
    private javax.swing.JLabel jLabel25;
    private javax.swing.JLabel jLabel26;
    private javax.swing.JLabel jLabel27;
    private javax.swing.JLabel jLabel28;
    private javax.swing.JLabel jLabel29;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel30;
    private javax.swing.JLabel jLabel31;
    private javax.swing.JLabel jLabel32;
    private javax.swing.JLabel jLabel33;
    private javax.swing.JLabel jLabel34;
    private javax.swing.JLabel jLabel35;
    private javax.swing.JLabel jLabel36;
    private javax.swing.JLabel jLabel37;
    private javax.swing.JLabel jLabel38;
    private javax.swing.JLabel jLabel39;
    private javax.swing.JLabel jLabel40;
    private javax.swing.JLabel jLabel41;
    private javax.swing.JLabel jLabel42;
    private javax.swing.JLabel jLabel43;
    private javax.swing.JLabel jLabel44;
    private javax.swing.JLabel jLabel45;
    private javax.swing.JLabel jLabel46;
    private javax.swing.JLabel jLabel47;
    private javax.swing.JLabel jLabel48;
    private javax.swing.JLabel jLabel49;
    private javax.swing.JLabel jLabel50;
    private javax.swing.JLabel jLabel51;
    private javax.swing.JLabel jLabel52;
    private javax.swing.JLabel jLabel53;
    private javax.swing.JLabel jLabel54;
    private javax.swing.JLabel jLabel55;
    private javax.swing.JLabel jLabel56;
    private javax.swing.JLabel jLabel57;
    private javax.swing.JLabel jLabel58;
    private javax.swing.JLabel jLabel59;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel60;
    private javax.swing.JLabel jLabel61;
    private javax.swing.JLabel jLabel62;
    private javax.swing.JLabel jLabel63;
    private javax.swing.JLabel jLabel64;
    private javax.swing.JLabel jLabel65;
    private javax.swing.JLabel jLabel66;
    private javax.swing.JLabel jLabel67;
    private javax.swing.JLabel jLabel68;
    private javax.swing.JLabel jLabel69;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JLabel jLabel70;
    private javax.swing.JLabel jLabel71;
    private javax.swing.JLabel jLabel72;
    private javax.swing.JLabel jLabel73;
    private javax.swing.JLabel jLabel74;
    private javax.swing.JLabel jLabel75;
    private javax.swing.JLabel jLabel76;
    private javax.swing.JLabel jLabel77;
    private javax.swing.JLabel jLabel78;
    private javax.swing.JLabel jLabel79;
    private javax.swing.JLabel jLabel8;
    private javax.swing.JLabel jLabel80;
    private javax.swing.JLabel jLabel81;
    private javax.swing.JLabel jLabel82;
    private javax.swing.JLabel jLabel83;
    private javax.swing.JLabel jLabel9;
    // End of variables declaration//GEN-END:variables
}
