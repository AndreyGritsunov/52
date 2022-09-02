void MassData(int[,] mass){
    
    for(int i = 0; i < mass.GetLength(1); i++){ 

        double d = 0;

        for(int a = 0; a < mass.GetLength(0); a++){
            mass[a, i] = new Random().Next(1, 10);
            d = d + mass[a, i];
        }
        Console.WriteLine("Средняя сумма в столбце №" + Convert.ToString(i + 1) + " равна " + Convert.ToString(d / mass.GetLength(0)));
    }    
} 

Console.WriteLine("Введите m число длинны массива Y: ");
int m = Convert.ToInt32(Console.ReadLine());

Console.WriteLine("Введите n число длинны массива X: ");
int n = Convert.ToInt32(Console.ReadLine());

int[,] mass = new int[m, n];

 MassData(mass);
 EchoMass(mass);




void EchoMass(int[,] mass){
    for(int i = 0; i < mass.GetLength(0); i++){
        for(int a = 0; a < mass.GetLength(1); a++){
           Console.Write(Convert.ToString(mass[i, a]) + " ");
        } 
        Console.WriteLine();   
    }     
}




