import java.awt.Color;
import java.awt.Dimension;
import java.awt.EventQueue;

import javax.swing.JFrame;
import javax.swing.JPanel;

public class Program {
    JFrame frame;

    public void initGUI(){
        frame =  new JFrame();

        frame.setPreferredSize(new Dimension(416, 300));
        frame.pack();

        JPanel p = (JPanel)frame.getContentPane();
        p.setBackground(Color.RED);
        //p.getVgap()

        System.out.println("Content pane size: [" + frame.getContentPane().getSize().width + ", " + frame.getContentPane().getSize().height + "]");
        System.out.println("frame size: [" + frame.getSize().width + "," + frame.getSize().height+"]");

        frame.setDefaultCloseOperation(JFrame.EXIT_ON_CLOSE);
        frame.setLocationRelativeTo(null);
        frame.setResizable(false);
        frame.setVisible(true);
    }

    public static void main(String[] args) {
        EventQueue.invokeLater(() ->{
            new Program().initGUI();
        });
    }
}