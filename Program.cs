int ReadInt(string message)
{
    System.Console.Write(message);
    return Convert.ToInt32(Console.ReadLine());
}

int [,] GenerateArray2DDD(int rows, int columns,int min, int max)
{
    
    int [,] numbers = new int [rows, columns];
    Random rnd = new Random ();
    
    for (int i = 0; i <numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
           numbers[i,j] = rnd.Next (min,max +1) ;
           
           
        }
        
    }

    
    
    return numbers;
}


int [,] sartirovka(int [,] numbers)
{
   int max = 0;
    int n = 0;
    int m = 0;
    
    for (int i = 0; i <numbers.GetLength(0); i++)
    {
         
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
           max=0;
            m=0;
            n= 0;
           for ( int k = j; k< numbers.GetLength(1);k++)
           {
            
           if (numbers[i,k]>max)
           {
           
            max = numbers[i,k];
            m=numbers [i,k] ;
            numbers[i,k] = n;
            n=m;

           }
           
           }
           numbers[i,j] = max;
           
            
        }
        
    }

    
    
    return numbers;
}








   
void PrintArray2Dd(int [,] numbers)
{
    for (int i = 0; i < numbers.GetLength(0); i++)
    {
        for (int j = 0; j < numbers.GetLength(1); j++)
        {
          System.Console.Write($"{numbers[i,j]}\t"); 
         }
System.Console.WriteLine();
 }
    System.Console.WriteLine();
    }
 
   
   
    int[,] array = GenerateArray2DDD(4,4,0,12);



PrintArray2Dd(array);
sartirovka(array);
PrintArray2Dd(array);


