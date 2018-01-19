using static System.Console;

public class Program
{
    public static void Main()
    {
        int num;
        int original = num = 51315;     
        int rev = 0;

        while (num > 0)
        {
            int dig = num % 10; //Captura cada dígito

            rev = rev * 10 + dig; 
            // (^) Adiciona o dígito na variável 'rev'.
            // Como usamos a base 10, tudo o que já existe 
            // em rev precisa ser mulplicado por 10

            num = num / 10;
            // Controla o loop
        }

        WriteLine(original == rev ? "É capícua" : "Não é capícua");
    }
}