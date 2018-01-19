import java.util.ArrayList;
import java.io.File;

public class Program
{
    public static void main(String args[])
    {
        String pasta = "D:\\Projetos\\Pessoais";
        File f = new File(pasta);
        listarArquivos(f);
    }

    private static List<File> listarArquivos(File source) 
    {
        List<File> fileList = new ArrayList<>();

        File[] list = source.listFiles();

        for (File fl : list) {
            if (!fl.isDirectory()) {
                fileList.add(fl);
                System.out.println(fl);
            }else{
                System.out.println(String.format("** Pasta: %s **", fl));
                listarArquivos(fl);
            }
        }

        return fileList;
    }
}
