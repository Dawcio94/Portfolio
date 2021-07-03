package vrp;

import java.util.ArrayList;
import java.util.Collections;
import java.util.List;
import java.util.Random;
import javafx.print.Collation;


public class JFvrp extends javax.swing.JFrame {
int ID=0;
Random ran = new Random();
route trasa = new route();
generation pokolenie = new generation();    
    public JFvrp() {
        initComponents();
        jTextArea4.setVisible(false);
        jScrollPane3.setVisible(false);
    }
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jTextField2 = new javax.swing.JTextField();
        jTextField3 = new javax.swing.JTextField();
        jTextField4 = new javax.swing.JTextField();
        jTextField5 = new javax.swing.JTextField();
        jButton1 = new javax.swing.JButton();
        jScrollPane1 = new javax.swing.JScrollPane();
        jTextArea2 = new javax.swing.JTextArea();
        jButton2 = new javax.swing.JButton();
        jC_Miasta1 = new javax.swing.JComboBox<>();
        jLabel1 = new javax.swing.JLabel();
        jLabel2 = new javax.swing.JLabel();
        jLabel3 = new javax.swing.JLabel();
        jLabel4 = new javax.swing.JLabel();
        jScrollPane2 = new javax.swing.JScrollPane();
        jTextArea1 = new javax.swing.JTextArea();
        jLabel5 = new javax.swing.JLabel();
        jC_Miasta2 = new javax.swing.JComboBox<>();
        jButton3 = new javax.swing.JButton();
        jLabel6 = new javax.swing.JLabel();
        jTextArea3 = new javax.swing.JTextArea();
        jLabel7 = new javax.swing.JLabel();
        jTextField1 = new javax.swing.JTextField();
        jButton4 = new javax.swing.JButton();
        jScrollPane3 = new javax.swing.JScrollPane();
        jTextArea4 = new javax.swing.JTextArea();

        setDefaultCloseOperation(javax.swing.WindowConstants.EXIT_ON_CLOSE);
        setTitle("Oskar Gruszczyński Dawid Gawiński - VRP ");

        jTextField2.setText("8");

        jTextField3.setText("0");

        jTextField4.setText("22");

        jTextField5.setText("0");

        jButton1.setText("Dodaj Punkt");
        jButton1.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton1ActionPerformed(evt);
            }
        });

        jTextArea2.setEditable(false);
        jTextArea2.setColumns(20);
        jTextArea2.setRows(5);
        jTextArea2.setBorder(javax.swing.BorderFactory.createTitledBorder(null, "Pokolenie", javax.swing.border.TitledBorder.CENTER, javax.swing.border.TitledBorder.TOP));
        jScrollPane1.setViewportView(jTextArea2);

        jButton2.setText("Generuj Pokolenie");
        jButton2.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton2ActionPerformed(evt);
            }
        });

        jC_Miasta1.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "BIALOGARD", "KOSZALIN", "SLUPSK", "KOLOBRZEG", "SZCZECINEK", "MIELNO" }));

        jLabel1.setText(":");

        jLabel2.setText("do");

        jLabel3.setText("od");

        jLabel4.setText(":");

        jTextArea1.setEditable(false);
        jTextArea1.setColumns(20);
        jTextArea1.setRows(5);
        jTextArea1.setBorder(javax.swing.BorderFactory.createTitledBorder(null, "TRASA", javax.swing.border.TitledBorder.CENTER, javax.swing.border.TitledBorder.TOP));
        jScrollPane2.setViewportView(jTextArea1);

        jLabel5.setText("Start/Stop:");

        jC_Miasta2.setModel(new javax.swing.DefaultComboBoxModel<>(new String[] { "BIALOGARD", "KOSZALIN", "SLUPSK", "KOLOBRZEG", "SZCZECINEK", "MIELNO" }));

        jButton3.setText("Akceptuj");
        jButton3.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton3ActionPerformed(evt);
            }
        });

        jLabel6.setText("Dostarcz do:");

        jTextArea3.setEditable(false);
        jTextArea3.setColumns(20);
        jTextArea3.setRows(5);
        jTextArea3.setBorder(javax.swing.BorderFactory.createTitledBorder(null, "NAJLEPSZA TRASA", javax.swing.border.TitledBorder.CENTER, javax.swing.border.TitledBorder.TOP));

        jLabel7.setText("Ilosc osobnikow: ");

        jTextField1.setText("100");

        jButton4.setText("Nastepne Pokolenie");
        jButton4.addActionListener(new java.awt.event.ActionListener() {
            public void actionPerformed(java.awt.event.ActionEvent evt) {
                jButton4ActionPerformed(evt);
            }
        });

        jTextArea4.setColumns(20);
        jTextArea4.setRows(5);
        jScrollPane3.setViewportView(jTextArea4);

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(getContentPane());
        getContentPane().setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                    .addComponent(jButton4)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(jLabel5)
                                .addGap(18, 18, 18)
                                .addComponent(jC_Miasta2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                            .addGroup(layout.createSequentialGroup()
                                .addComponent(jLabel6)
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                .addComponent(jC_Miasta1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)))
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createSequentialGroup()
                                .addGap(20, 20, 20)
                                .addComponent(jButton3))
                            .addGroup(layout.createSequentialGroup()
                                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                                    .addComponent(jLabel3)
                                    .addGroup(layout.createSequentialGroup()
                                        .addGap(17, 17, 17)
                                        .addComponent(jTextField2, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(jLabel1)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(jTextField3, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(jLabel2)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(jTextField4, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(jLabel4)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(jTextField5, javax.swing.GroupLayout.PREFERRED_SIZE, 25, javax.swing.GroupLayout.PREFERRED_SIZE)
                                        .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                        .addComponent(jButton1))))))
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING, false)
                            .addComponent(jScrollPane1, javax.swing.GroupLayout.Alignment.LEADING)
                            .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                                .addGroup(javax.swing.GroupLayout.Alignment.LEADING, layout.createSequentialGroup()
                                    .addComponent(jLabel7)
                                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                                    .addComponent(jTextField1, javax.swing.GroupLayout.PREFERRED_SIZE, 40, javax.swing.GroupLayout.PREFERRED_SIZE)
                                    .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                                    .addComponent(jButton2))
                                .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 236, javax.swing.GroupLayout.PREFERRED_SIZE)))
                        .addGap(52, 52, 52)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
                            .addComponent(jTextArea3, javax.swing.GroupLayout.PREFERRED_SIZE, 218, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jScrollPane3, javax.swing.GroupLayout.PREFERRED_SIZE, 228, javax.swing.GroupLayout.PREFERRED_SIZE))))
                .addContainerGap(76, Short.MAX_VALUE))
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addGroup(layout.createSequentialGroup()
                .addContainerGap()
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.TRAILING)
                    .addGroup(layout.createSequentialGroup()
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jLabel5)
                            .addComponent(jC_Miasta2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jButton3))
                        .addGap(6, 6, 6)
                        .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                            .addComponent(jC_Miasta1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jTextField2, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jTextField3, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jTextField4, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jTextField5, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE)
                            .addComponent(jLabel1)
                            .addComponent(jLabel4)
                            .addComponent(jLabel2)
                            .addComponent(jLabel3)
                            .addComponent(jLabel6)
                            .addComponent(jButton1))
                        .addGap(18, 18, 18)
                        .addComponent(jScrollPane2, javax.swing.GroupLayout.PREFERRED_SIZE, 244, javax.swing.GroupLayout.PREFERRED_SIZE))
                    .addComponent(jTextArea3, javax.swing.GroupLayout.PREFERRED_SIZE, 242, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addGap(18, 18, 18)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.BASELINE)
                    .addComponent(jButton2)
                    .addComponent(jLabel7)
                    .addComponent(jTextField1, javax.swing.GroupLayout.PREFERRED_SIZE, javax.swing.GroupLayout.DEFAULT_SIZE, javax.swing.GroupLayout.PREFERRED_SIZE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.RELATED)
                .addGroup(layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING, false)
                    .addComponent(jScrollPane3)
                    .addComponent(jScrollPane1, javax.swing.GroupLayout.DEFAULT_SIZE, 244, Short.MAX_VALUE))
                .addPreferredGap(javax.swing.LayoutStyle.ComponentPlacement.UNRELATED)
                .addComponent(jButton4)
                .addContainerGap(79, Short.MAX_VALUE))
        );

        jTextField3.getAccessibleContext().setAccessibleName("");

        pack();
    }// </editor-fold>//GEN-END:initComponents

    
    
    private void jButton1ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton1ActionPerformed
        if (Integer.parseInt(jTextField2.getText())>22)
        {
            jTextField2.setText("22");
        }
        
         if (Integer.parseInt(jTextField2.getText())>Integer.parseInt(jTextField4.getText()))
        {
            jTextField2.setText("8");
        }
        if (Integer.parseInt(jTextField2.getText())<8)
        {
            jTextField2.setText("8");
        }
        
        if (Integer.parseInt(jTextField3.getText())>59)
        {
            jTextField3.setText("59");
        }
        if (Integer.parseInt(jTextField3.getText())<0)
        {
            jTextField3.setText("0");
        }
        
         if (Integer.parseInt(jTextField4.getText())>22)
        {
            jTextField4.setText("22");
        }
        if (Integer.parseInt(jTextField4.getText())<8)
        {
            jTextField4.setText("8");
        }
        
         if (Integer.parseInt(jTextField5.getText())>59)
        {
            jTextField5.setText("59");
        }
        if (Integer.parseInt(jTextField5.getText())<0)
        {
            jTextField5.setText("0");
        }
        
        
       point buff = new point (ID,jC_Miasta1.getSelectedItem().toString(),Integer.parseInt(jTextField2.getText()),Integer.parseInt(jTextField3.getText()),Integer.parseInt(jTextField4.getText()),Integer.parseInt(jTextField5.getText()));
       trasa.addPoint(buff);
       jTextArea1.append(trasa.getPoint(ID).getText()+"\n");
       ID+=1;
    }//GEN-LAST:event_jButton1ActionPerformed

    private void jButton2ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton2ActionPerformed
       
       for (int x=0;x<Integer.parseInt(jTextField1.getText());x++)
       {  
        pokolenie.addRoute(trasa.random());
       }
      pokolenie.skalowanieFC();
          
    for (int x=0;x<Integer.parseInt(jTextField1.getText());x++)
    {    
        jTextArea2.append(x+": ");
        for (int y=0; y<trasa.getSize();y++)
        {
            jTextArea2.append(pokolenie.getRoute(x).getPoint(y).getID()+", ");
        }
        jTextArea2.append(" FC="+pokolenie.getRoute(x).getFC()+"\n");
    }
    jTextArea3.append("Start/Stop: "+trasa.getStartStop()+"\n");
    for (int x=0;x<trasa.getSize();x++)
    {
       
        jTextArea3.append(pokolenie.getBest().getPoint(x).getText()+"\n");
    }
    }//GEN-LAST:event_jButton2ActionPerformed

    private void jButton3ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton3ActionPerformed
        trasa.setStartStop(jC_Miasta2.getSelectedItem().toString());   
        jTextArea1.append("Start/stop: "+ trasa.getStartStop()+"\n");
        
    }//GEN-LAST:event_jButton3ActionPerformed
    
    private void jButton4ActionPerformed(java.awt.event.ActionEvent evt) {//GEN-FIRST:event_jButton4ActionPerformed
        pokolenie.ewoluuj();
        pokolenie.skalowanieFC();
      
        jTextArea2.setText("");
        for (int x=0;x<Integer.parseInt(jTextField1.getText());x++)
        {    
            jTextArea2.append(x+": ");
        for (int y=0; y<trasa.getSize();y++)
        {
            jTextArea2.append(pokolenie.getRoute(x).getPoint(y).getID()+", ");
        }
        jTextArea2.append(" FC="+pokolenie.getRoute(x).getFC()+"\n");
        }
        jTextArea3.setText("");
        jTextArea3.append("Start/Stop: "+trasa.getStartStop()+"\n");
        for (int x=0;x<trasa.getSize();x++)
        {
       
        jTextArea3.append(pokolenie.getBest().getPoint(x).getText()+"\n");
        }
        
        
        jTextArea4.setText(" ");
        for (int x=0;x<pokolenie.subpokolenie.size();x++)
        {    
        jTextArea4.append(x+": ");
        for (int y=0; y<trasa.getSize();y++)
        {
            jTextArea4.append(pokolenie.subpokolenie.get(x).getPoint(y).getID()+", ");
        }
        jTextArea4.append(" FC="+pokolenie.subpokolenie.get(x).getFC()+"\n");
        }
        
        pokolenie.subpokolenie.clear();
    }//GEN-LAST:event_jButton4ActionPerformed

  
    public static void main(String args[]) {
        
        java.awt.EventQueue.invokeLater(new Runnable() {
            public void run() {
                new JFvrp().setVisible(true);
            }
        });
    }

    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JButton jButton1;
    private javax.swing.JButton jButton2;
    private javax.swing.JButton jButton3;
    private javax.swing.JButton jButton4;
    private javax.swing.JComboBox<String> jC_Miasta1;
    private javax.swing.JComboBox<String> jC_Miasta2;
    private javax.swing.JLabel jLabel1;
    private javax.swing.JLabel jLabel2;
    private javax.swing.JLabel jLabel3;
    private javax.swing.JLabel jLabel4;
    private javax.swing.JLabel jLabel5;
    private javax.swing.JLabel jLabel6;
    private javax.swing.JLabel jLabel7;
    private javax.swing.JScrollPane jScrollPane1;
    private javax.swing.JScrollPane jScrollPane2;
    private javax.swing.JScrollPane jScrollPane3;
    private javax.swing.JTextArea jTextArea1;
    private javax.swing.JTextArea jTextArea2;
    private javax.swing.JTextArea jTextArea3;
    private javax.swing.JTextArea jTextArea4;
    private javax.swing.JTextField jTextField1;
    private javax.swing.JTextField jTextField2;
    private javax.swing.JTextField jTextField3;
    private javax.swing.JTextField jTextField4;
    private javax.swing.JTextField jTextField5;
    // End of variables declaration//GEN-END:variables
}
