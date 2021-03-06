/*
 * To change this license header, choose License Headers in Project Properties.
 * To change this template file, choose Tools | Templates
 * and open the template in the editor.
 */
package oskardawid;

import static java.lang.Math.pow;
import java.util.ArrayList;
import java.util.List;
import java.util.Random;
import javax.swing.JLabel;
import javax.swing.JTextField;

/**
 *
 * @author Krystian
 */



public class Okienko extends javax.swing.JFrame {

    int size=0;
    int fs2=Integer.MIN_VALUE;
    double fs2l=0; 
    double fs2count=0;
    double fs3l=0; 
    int fs3=Integer.MIN_VALUE;
    double fs3count=0;
    double fs5l=0; 
    int fs5=Integer.MIN_VALUE;
    double fs5count=0;
    double fs6l=0; 
    int fs6=Integer.MIN_VALUE;
    double fs6count=0;
    double fs7l=0; 
    double fs7count=0;
    double fs8l=0; 
    int fsmax=Integer.MIN_VALUE;
    double fs8count=0;
    int[][] taba = new int [10][10];
    int[][] tabd = new int [10][10];
    int[] tabx = new int [10];
    int[] tabb= new int[10];
    int determinanta =1;
   
    public Okienko() {
        initComponents();
        jt_t.setText("NR  i  j  Fs2  Fs3  Fs5  Fs6  Fs7 Fs8 Fst \n"); 
        
        
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    
    
 public double determ(int a[][], int n) 
 {
    double det=0;
    int[][] temp = new int [10][10];
    int p, h, k, i, j;
    if(n==1) 
    {
        return a[0][0];
    } 
    else if(n==2) 
    {
        det=(a[0][0]*a[1][1]-a[0][1]*a[1][0]);
        return det;
    } 
    else 
    {
        for(p=0;p<n;p++) 
        {
            h = 0;
            k = 0;
            for(i=1;i<n;i++) 
            {
                for( j=0;j<n;j++) 
                {
                    if(j==p) 
                    {
                        continue;
                    }
                    temp[h][k] = a[i][j];
                    k++;
                    if(k==n-1) 
                    {
                        h++;
                        k = 0;
                    }
                }
            }
             det=det+a[0][p]*pow(-1,p)*determ(temp,n-1);
        }
        return det;
    }
 }

    
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jp_Menu = new javax.swing.JPanel();
        jLabel1 = new javax.swing.JLabel();
        jt_Size = new javax.swing.JTextField();
        jButton1 = new javax.swing.JButton();
        jButton4 = new javax.swing.JButton();
        jButton5 = new javax.swing.JButton();
        jTextArea2 = new javax.swing.JTextArea();
        jTextArea1 = new javax.swing.JTextArea();
        jTextArea3 = new javax.swing.JTextArea();
        jTextArea7 = new javax.swing.JTextArea();
        jt_w = new javax.swing.JTextArea();
        jt_l = new javax.swing.JTextArea();
        jt_t = new javax.swing.JTextArea();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Oskar Dawid - Metoda Iteracji Prostej");
        setCursor(new java.awt.Cursor(java.awt.Cursor.HAND_CURSOR));

        jLabel1.setText("Rozmiar macierzy A:");

        jt_Size.setHorizontalAlignment(javax.swing.JTextField.RIGHT);
        jt_Size.setToolTipText("Rozmiar macierzy symetrycznej w przedziale 2-10");
        jt_Size.setAutoscrolls(false);

        jButton1.setText("Akceptuj");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        jButton4.setText("Generuj");
        jButton4.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton4ActionPerformed(evt);
            }
        });

        jButton5.setText("Oblicz");
        jButton5.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton5ActionPerformed(evt);
            }
        });

        jTextArea2.setEditable(false);
        jTextArea2.setColumns(20);
        jTextArea2.setRows(3);
        jTextArea2.setTabSize(14);
        jTextArea2.setAutoscrolls(false);
        jTextArea2.setBorder(javax.swing.BorderFactory.createTitledBorder(null, "Macierz A", javax.swing.border.TitledBorder.CENTER, javax.swing.border.TitledBorder.TOP));

        jTextArea1.setEditable(false);
        jTextArea1.setColumns(20);
        jTextArea1.setRows(30);
        jTextArea1.setBorder(javax.swing.BorderFactory.createTitledBorder(null, "X", javax.swing.border.TitledBorder.CENTER, javax.swing.border.TitledBorder.TOP));

        jTextArea3.setEditable(false);
        jTextArea3.setColumns(20);
        jTextArea3.setRows(3);
        jTextArea3.setTabSize(14);
        jTextArea3.setAutoscrolls(false);
        jTextArea3.setBorder(javax.swing.BorderFactory.createTitledBorder(null, "Macierz D", javax.swing.border.TitledBorder.CENTER, javax.swing.border.TitledBorder.TOP));

        jTextArea7.setColumns(20);
        jTextArea7.setRows(5);
        jTextArea7.setBorder(javax.swing.BorderFactory.createTitledBorder(null, "X'", javax.swing.border.TitledBorder.CENTER, javax.swing.border.TitledBorder.TOP));

        javax.swing.GroupLayout jp_MenuLayout = new javax.swing.GroupLayout(jp_Menu);
        jp_Menu.setLayout(jp_MenuLayout);
        jp_MenuLayout.setHorizontalGroup(
            jp_MenuLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jp_MenuLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jp_MenuLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addGroup(jp_MenuLayout.createSequentialGroup()
                        .addComponent(jLabel1)
                        .addGap(18, 18, 18)
                        .addComponent(jt_Size, javax.swing.GroupLayout.PREFERRED_SIZE, 79, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(jButton1))
                    .addGroup(jp_MenuLayout.createSequentialGroup()
                        .addComponent(jTextArea3, javax.swing.GroupLayout.PREFERRED_SIZE, 223, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(jTextArea7, javax.swing.GroupLayout.PREFERRED_SIZE, 48, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(jp_MenuLayout.createSequentialGroup()
                        .addComponent(jTextArea2, javax.swing.GroupLayout.PREFERRED_SIZE, 223, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                        .addComponent(jTextArea1, javax.swing.GroupLayout.PREFERRED_SIZE, 48, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addGroup(jp_MenuLayout.createSequentialGroup()
                        .addComponent(jButton4, javax.swing.GroupLayout.PREFERRED_SIZE, 142, javax.swing.GroupLayout.PREFERRED_SIZE)
                        .addGap(18, 18, 18)
                        .addComponent(jButton5, javax.swing.GroupLayout.PREFERRED_SIZE, 136, javax.swing.GroupLayout.PREFERRED_SIZE)))
                .addContainerGap(javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE))
        );
        jp_MenuLayout.setVerticalGroup(
            jp_MenuLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(jp_MenuLayout.createSequentialGroup()
                .addContainerGap()
                .addGroup(jp_MenuLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jLabel1)
                    .addComponent(jt_Size, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jButton1))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jp_MenuLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jButton4)
                    .addComponent(jButton5))
                .addGap(20, 20, 20)
                .addGroup(jp_MenuLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jTextArea2, javax.swing.GroupLayout.PREFERRED_SIZE, 200, javax.swing.GroupLayout.PREFERRED_SIZE)
                    .addComponent(jTextArea1, javax.swing.GroupLayout.PREFERRED_SIZE, 198, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(jp_MenuLayout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jTextArea3, javax.swing.GroupLayout.DEFAULT_SIZE, 212, Short.MAX_VALUE)
                    .addComponent(jTextArea7))
                .addContainerGap())
        );

        jTextArea2.getAccessibleContext().setAccessibleParent(jTextArea2);

        jt_w.setColumns(20);
        jt_w.setRows(5);
        jt_w.setBorder(javax.swing.BorderFactory.createTitledBorder(null, "Wierzcho??ki", javax.swing.border.TitledBorder.CENTER, javax.swing.border.TitledBorder.TOP));

        jt_l.setColumns(20);
        jt_l.setRows(5);
        jt_l.setBorder(javax.swing.BorderFactory.createTitledBorder(null, "??uki", javax.swing.border.TitledBorder.CENTER, javax.swing.border.TitledBorder.TOP));

        jt_t.setColumns(20);
        jt_t.setRows(5);
        jt_t.setBorder(javax.swing.BorderFactory.createTitledBorder(null, "Tabela Struktur", javax.swing.border.TitledBorder.CENTER, javax.swing.border.TitledBorder.TOP));

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addComponent(jp_Menu, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jt_w, javax.swing.GroupLayout.PREFERRED_SIZE, 131, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jt_l, javax.swing.GroupLayout.PREFERRED_SIZE, 127, javax.swing.GroupLayout.PREFERRED_SIZE)
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addComponent(jt_t, javax.swing.GroupLayout.DEFAULT_SIZE, 393, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jp_Menu, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, Short.MAX_VALUE)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jt_w)
                    .addComponent(jt_l)
                    .addComponent(jt_t))
                .addContainerGap())
        );

        pack();
    }// </editor-fold>//GEN-END:initComponents

    private void jButton5ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton5ActionPerformed
        jTextArea3.setText("");
        jTextArea7.setText("");
        jt_w.setText("");
        jt_l.setText("");
        jt_t.setText("NR  i  j  Fs2  Fs3  Fs5  Fs6  Fs7 Fs8 Fst \n");
        fs2count=0;
        fs3count=0;
        fs5count=0;
        fs6count=0;
        fs7count=0;
        fs8count=0;
        if (determ(taba,size)<1)
        {
            for (int i=0;i<size;i++)
            {
                for (int j=0;j<size;j++)
                {
                    if (i==j)
                    {
                        tabd[i][j]=taba[i][j]-1;
                    }
                    else
                    {
                        tabd[i][j]=taba[i][j];
                    }

                    if (tabd[i][j]<10)
                    {
                        jTextArea3.append("  "+tabd[i][j]+ "  ");
                    }
                    else
                    {
                        jTextArea3.append(tabd[i][j]+ "  ");
                    }
                }
                jTextArea3.append("\n");
            }

            for(int i=0;i<size;i++)
            {
                tabx[i]=tabb[i];
            }
            int l=0;
            for (int i=0;i<size;i++)
            {
                
                for (int j=0;j<size;j++)
                {
                   
                    tabb[i]=tabb[i]+(tabd[i][j]*tabx[j]);
                     l=l+1;
                     if (j+1!=fs2)
                     {
                         fs2=j+1;
                         fs2count+=1;
                     }
                     
                     if (i+1!=fs3)
                     {
                         fs3=i+1;
                         fs3count+=1;
                     }
                     
                      if (j+1*-1!=fs5)
                     {
                         fs5=j+1*-1;
                         fs5count+=1;
                     }
                      
                      if (i+1*-1!=fs6)
                     {
                         fs6=i+1*-1;
                         fs6count+=1;
                     }
                      
                
                        
                        if (i+1+j+1-1>fsmax)
                     {
                         fsmax=i+1+j+1-1;
                     }
                     if(l<10)
                     {
                         jt_w.append("  "+l +": "+(i+1)+" "+(j+1)+"\n");
                         jt_t.append("  "+l +": "+(i+1)+" "+(j+1)+"    "+(j+1)+"       "+(i+1)+"     "+((j+1)*-1)+"     "+((i+1)*-1)+"       "+(i-j)+"      "+((i-j)*-1)+"      "+(i+1+j+1-1)+"\n");
                     }
                     else
                     {
                        jt_w.append(l +": "+(i+1)+" "+(j+1)+"\n"); 
                        jt_t.append(l +": "+(i+1)+" "+(j+1)+"    "+(j+1)+"       "+(i+1)+"     "+((j+1)*-1)+"     "+((i+1)*-1)+"       "+(i-j)+"      "+((i-j)*-1)+"      "+(i+1+j+1-1)+"\n"); 
                     }
                     
                                     
                     if(i+1 == size && j+1 ==size)
                     {
                         
                     }
                     else
                     {
              
                     jt_l.append((i+1)+" "+(j+1)+": ");
                        if(i+2<=size)
                     {     
                         jt_l.append("("+(i+2)+" "+(j+1)+")"+" ");
                      }
                        if (j+2<=size)
                        {
                            jt_l.append("("+(i+1)+" "+(j+2)+")"+"\n");
                        }
                        else
                        {
                            jt_l.append("\n");
                        }
                }
                }
            }
        
        fs2l=(fs2count/size);  
        fs2count=(size*size)/((fs2count/size)*fsmax);
        fs3l=fs3count;  
        fs3count=(size*size)/(fs3count*fsmax);
        fs5l=  (fs5count/size);  
        fs5count=(size*size)/((fs5count/size)*fsmax);
        fs6l=  fs6count;  
        fs6count=(size*size)/(fs6count*fsmax);
        fs7l=  (double)(size-1)*2+1;  
        fs7count=(double)(size*size)/(double)(((size-1)*2+1)*fsmax);
        fs8l=  (double)(size-1)*2+1; 
        fs8count=(double)(size*size)/(double)(((size-1)*2+1)*fsmax);
            for(int j=0;j<size;j++)
            {
                jTextArea7.append(+tabb[j]+"\n");
            }
            
            String oskar= String.format("%.2f", fs2count);
        jt_t.append("Wo:    "+oskar+"  ");
        oskar= String.format("%.2f", fs3count);
        jt_t.append(oskar+"  ");
        oskar= String.format("%.2f", fs5count);
        jt_t.append(oskar+"  ");
        oskar= String.format("%.2f", fs6count);
        jt_t.append(oskar+"  ");
        oskar= String.format("%.2f", fs7count);
        jt_t.append(oskar+"  ");
        oskar= String.format("%.2f", fs8count);
        jt_t.append(oskar+"  ");
        jt_t.append("\n");
        oskar= String.format("%.2f", fs2l);
        jt_t.append("EP:    "+oskar+"  ");
        oskar= String.format("%.2f", fs3l);
        jt_t.append(oskar+"  ");
        oskar= String.format("%.2f", fs5l);
        jt_t.append(oskar+"  ");
        oskar= String.format("%.2f", fs6l);
        jt_t.append(oskar+"  ");
        oskar= String.format("%.2f", fs7l);
        jt_t.append(oskar+"  ");
        oskar= String.format("%.2f", fs8l);
        jt_t.append(oskar+"  ");
        jt_t.append("\n");
        jt_t.append("Kanaly:  1      1       1       1       2        2 \n");
        jt_t.append("Kierunek: ???   ???       ???       ???     ??????   ??????");
        
        jt_l.append("\n \n      Macierz D   \n");
        jt_l.append("        |1 0| \n");
        jt_l.append("        |0 1| \n");
        }
        else
        {
            jTextArea3.append("Wyznacznik = "+ determ(taba,size) + "\ndalsze dzia??ania nie mozliwe");
        }
       
        
        
    
        
    }//GEN-LAST:event_jButton5ActionPerformed

    private void jButton4ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton4ActionPerformed
        Random rn = new Random();
        jTextArea2.setText("");
        jTextArea1.setText("");
        jt_w.setText("");
        jt_l.setText("");
        jt_t.setText("NR  i  j  Fs2  Fs3  Fs5  Fs6  Fs7 Fs8 Fst \n");

        for (int x=0;x<size;x++)
        {
            tabb[x]=rn.nextInt(10) + 1;
            jTextArea1.append("  "+tabb[x]+" ");
            for (int y=0;y<size;y++)
            {
                taba[x][y]=rn.nextInt(10) + 1;
                if (taba[x][y]<10)
                {
                    jTextArea2.append("  "+taba[x][y]+ "  ");
                }
                else
                {
                    jTextArea2.append(taba[x][y]+ "  ");
                }
            }
            jTextArea2.append("\n");
            jTextArea1.append("\n");
        }
    }//GEN-LAST:event_jButton4ActionPerformed

    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        size=Integer.parseInt(jt_Size.getText());

        if(size<2)
        {
            size=2;
            jt_Size.setText("2");
        }
        if(size>10)
        {
            size=10;
            jt_Size.setText("10");
        }
        jTextArea2.setBorder(javax.swing.BorderFactory.createTitledBorder(null, "Macierz A"+" "+size+"x"+size, javax.swing.border.TitledBorder.CENTER, javax.swing.border.TitledBorder.TOP));
        jTextArea2.setText("");
        jTextArea1.setText("");
        jTextArea3.setText("");
        jTextArea7.setText("");
        jt_w.setText("");
        jt_l.setText("");
        jt_t.setText("NR  i  j  Fs2  Fs3  Fs5  Fs6  Fs7 Fs8 Fst \n");
    }//GEN-LAST:event_jButton1ActionPerformed

    
    /**
     * @param args the command line arguments
     */
    public static void main(String args[]) {
        /* Set the Nimbus look and feel */
        //<editor-fold defaultstate="collapsed" desc=" Look and feel setting code (optional) ">
        /* If Nimbus (introduced in Java SE 6) is not available, stay with the default look and feel.
         * For details see http://download.oracle.com/javase/tutorial/uiswing/lookandfeel/plaf.html 
         */
        try {
            for (javax.swing.UIManager.LookAndFeelInfo info : javax.swing.UIManager.getInstalledLookAndFeels()) {
                if ("Nimbus".equals(info.getName())) {
                    javax.swing.UIManager.setLookAndFeel(info.getClassName());
                    break;
                }
            }
        } catch (ClassNotFoundException ex) {
            java.util.logging.Logger.getLogger(Okienko.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (InstantiationException ex) {
            java.util.logging.Logger.getLogger(Okienko.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (IllegalAccessException ex) {
            java.util.logging.Logger.getLogger(Okienko.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        } catch (javax.swing.UnsupportedLookAndFeelException ex) {
            java.util.logging.Logger.getLogger(Okienko.class.getName()).log(java.util.logging.Level.SEVERE, null, ex);
        }
        //</editor-fold>

        /* Create and display the form */
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new Okienko().setVisible(true);
                
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton4;
    private javax.swing.JButton jButton5;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JTextArea jTextArea1;
    private javax.swing.JTextArea jTextArea2;
    private javax.swing.JTextArea jTextArea3;
    private javax.swing.JTextArea jTextArea7;
    private javax.swing.JPanel jp_Menu;
    private javax.swing.JTextField jt_Size;
    private javax.swing.JTextArea jt_l;
    private javax.swing.JTextArea jt_t;
    private javax.swing.JTextArea jt_w;
    // End of variables declaration//GEN-END:variables
}
