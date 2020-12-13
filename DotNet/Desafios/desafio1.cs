using System;

class Desafio {
    static void Main() {
        int limit = Int32.Parse(Console.ReadLine());
        for (int i = 0; i < limit; i++) 
        {
            string[] line = Console.ReadLine().Split(" ");
            double X = double.Parse(line[0]);
            double Y = double.Parse(line[1]);
            if (Y == 0) {
                Console.WriteLine("divisao impossivel");
            } else {
                double divisao = X / Y;
                
                if(0.5 < divisao > 1.0){
                  Console.WriteLine("0");
                }else{
                Console.WriteLine(divisao.ToString("N1"));
                }
            }
        }
    }
}