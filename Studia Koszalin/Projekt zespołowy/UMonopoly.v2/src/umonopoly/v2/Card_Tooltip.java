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
public class Card_Tooltip extends javax.swing.JComponent {

    private int ID;

    public int getNr() {
        return ID;
    }

    public void setNr(int nr) {
        this.ID = nr;
        switch(ID)
        {
            case 2:
                jLabel2.setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(ID+".png")+"\">");
                break;
            case 4:
                
                jLabel2.setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(ID+".png")+"\">");
                break;
            case 6:
              
                jLabel2.setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(ID+".png")+"\">");
                break;
            case 7:
               
                jLabel2.setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(ID+".png")+"\">");
                break;
            case 9:
                
                jLabel2.setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(ID+".png")+"\">");
                break;
            case 10:
               
                jLabel2.setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(ID+".png")+"\">");
                break;
            case 12:
                
                jLabel2.setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(ID+".png")+"\">");
                break;
            case 13:
              
                jLabel2.setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(ID+".png")+"\">");
                break;
            case 14:
                
                jLabel2.setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(ID+".png")+"\">");
                break;
            case 15:
               jLabel2.setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(ID+".png")+"\">");
                break;
            case 16:
               
                jLabel2.setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(ID+".png")+"\">");
                break;
            case 17:
                
                jLabel2.setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(ID+".png")+"\">");
                break;
            case 19:
               jLabel2.setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(ID+".png")+"\">");
                break;
            case 20:
               
                jLabel2.setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(ID+".png")+"\">");
                break;
            case 22:
               
                jLabel2.setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(ID+".png")+"\">");
                break;
            case 24:
               
                jLabel2.setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(ID+".png")+"\">");
                break;
            case 25:
                
                jLabel2.setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(ID+".png")+"\">");
                break;
            case 26:
               
                jLabel2.setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(ID+".png")+"\">");
                break;
            case 27:
                
                jLabel2.setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(ID+".png")+"\">");
                break;
            case 28:
               
                jLabel2.setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(ID+".png")+"\">");
                break;
            case 29:
                
                jLabel2.setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(ID+".png")+"\">");
                break;
            case 30:
                
                jLabel2.setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(ID+".png")+"\">");
                break;
            case 32:
                
                jLabel2.setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(ID+".png")+"\">");
                break;
            case 33:
                
                jLabel2.setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(ID+".png")+"\">");
                break;
            case 35:
                
                jLabel2.setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(ID+".png")+"\">");
                break;
            case 36:
                
                jLabel2.setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(ID+".png")+"\">");
                break;
            case 38:
                
                jLabel2.setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(ID+".png")+"\">");
                break;
            case 40:
                
                jLabel2.setToolTipText("<html><img src=\"" +Card_Tooltip.class.getResource(ID+".png")+"\">");
                break;
           
        }
    }
    
    
    
    public Card_Tooltip() 
    {
        initComponents();
        
    }

    /**
     * This method is called from within the constructor to initialize the form.
     * WARNING: Do NOT modify this code. The content of this method is always
     * regenerated by the Form Editor.
     */
    @SuppressWarnings("unchecked")
    // <editor-fold defaultstate="collapsed" desc="Generated Code">//GEN-BEGIN:initComponents
    private void initComponents() {

        jLabel2 = new javax.swing.JLabel();

        javax.swing.GroupLayout layout = new javax.swing.GroupLayout(this);
        this.setLayout(layout);
        layout.setHorizontalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jLabel2, javax.swing.GroupLayout.DEFAULT_SIZE, 166, Short.MAX_VALUE)
        );
        layout.setVerticalGroup(
            layout.createParallelGroup(javax.swing.GroupLayout.Alignment.LEADING)
            .addComponent(jLabel2, javax.swing.GroupLayout.DEFAULT_SIZE, 36, Short.MAX_VALUE)
        );
    }// </editor-fold>//GEN-END:initComponents


    // Variables declaration - do not modify//GEN-BEGIN:variables
    private javax.swing.JLabel jLabel2;
    // End of variables declaration//GEN-END:variables
}
