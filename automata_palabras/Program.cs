using System.IO; //Biblioteca para las funciones reader y writer
using System.Net.Http.Headers;
using System.Runtime.CompilerServices;

public class Program
{
    public static void Main()
    {
        //Creamos el archivo si no existe.
        string path = "prueba.txt";
        if (File.Exists(path)) Console.WriteLine("Si existe el archivo");
        else
        {
            StreamWriter creacion = new StreamWriter(path);
            creacion.WriteLine("for a;");
            creacion.Close();
        }
        //Lectura del archivo
        StreamReader sr = new StreamReader(path); //crear el objeto de lectura
        string contenido = sr.ReadToEnd(); //Leer todo el contenido del archivo
        string[] lineas = contenido.Split('\n');

        string[] palabras = { " ", " " };

        for (int i = 0; i < lineas.Length; i++)
        {
            palabras = lineas[i].Split(' '); //Palabras guardadas en un arreglo

            for (int j = 0; j < palabras.Length; j++)
            {
                int longitud_palabras = palabras[j].Length;


                Console.WriteLine("Evaluando la palabra: " + palabras[j]);
                double estadoActual = 0;
                double[] estadoFinal = {-1};
                //varios estados finales
                for (int k = 0; k < palabras[j].Length; k++)
                {
                    switch (palabras[j][k])
                    {
                        case 'a':
                            if (estadoActual == 0) estadoActual = 1;
                            else if (estadoActual == 9) estadoActual = 10;
                            else if (estadoActual == 22) estadoActual = 23;
                            else if (estadoActual == 30) estadoActual = 31;
                            else if (estadoActual == 39) estadoActual = 40;
                            break;
                        case 'b':
                            if (estadoActual == 0) estadoActual = 1;
                            else if (estadoActual == 2) estadoActual = 3;
                            else if (estadoActual == 26) estadoActual = 27;
                            break;
                        case 'c':
                            if (estadoActual == 0) estadoActual = 1;
                            else if (estadoActual == 5) estadoActual = -1;
                            else if (estadoActual == 15) estadoActual = 16;
                            break;
                        case 'd':
                            if (estadoActual == 0) estadoActual = 1;
                            else if (estadoActual == 18) estadoActual = -1;
                            break;
                        case 'e':
                            if (estadoActual == 0) estadoActual = 1;
                            else if (estadoActual == 11) estadoActual = -1;
                            else if (estadoActual == 14) estadoActual = 15;
                            else if (estadoActual == 17) estadoActual = 18;
                            else if (estadoActual == 28) estadoActual = -1;
                            else if (estadoActual == 38) estadoActual= 39;
                            break;
                        case 'f':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'g':
                            if (estadoActual == 0) estadoActual = 1;
                            else if (estadoActual == 35) estadoActual = -1;
                            break;
                        case 'h':
                            if (estadoActual == 0) estadoActual = 1;
                            else if(estadoActual == 1) estadoActual = 22;
                            break;
                        case 'i':
                            if (estadoActual == 0) estadoActual = 1;
                            else if (estadoActual == 4) estadoActual = 5;
                            else if (estadoActual == 7) estadoActual = 8;
                            else if (estadoActual == 33) estadoActual = 34;
                            break;
                        case 'j':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'k':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'l':
                            if (estadoActual == 0) estadoActual = 1;
                            else if (estadoActual == 3) estadoActual = 4;
                            else if (estadoActual == 27) estadoActual = 28;
                            else if (estadoActual == 1) estadoActual = 29;
                            else if (estadoActual == 37) estadoActual = 38;
                            break;
                        case 'm':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'n':
                            if (estadoActual == 0) estadoActual = 1;
                            else if (estadoActual == 1) estadoActual = 20;
                            else if (estadoActual == 34) estadoActual = 35;
                            else if (estadoActual == 40) estadoActual = -1;
                            break;
                        case 'o':
                            if (estadoActual == 0) estadoActual = 1;
                            else if (estadoActual == 7) estadoActual = 13;
                            else if (estadoActual == 1) estadoActual = 25;
                            else if (estadoActual == 29) estadoActual = 30;
                            else if (estadoActual == 1) estadoActual = 36;
                            else if (estadoActual == 36) estadoActual = 37;
                            break;
                        case 'p':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'q':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'r':
                            if (estadoActual == 0) estadoActual = 1;
                            else if (estadoActual == 1) estadoActual = 7;
                            else if (estadoActual == 23) estadoActual = -1;
                            else if (estadoActual == 32) estadoActual = 33;
                            break;
                        case 's':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 't':
                            if (estadoActual == 0) estadoActual = 1;
                            else if (estadoActual == 10) estadoActual = 11;
                            else if (estadoActual == 13) estadoActual = 14;
                            else if (estadoActual == 16) estadoActual = 17;
                            else if (estadoActual == 20) estadoActual = -1;
                            else if (estadoActual == 31) estadoActual = -1;
                            else if (estadoActual == 1) estadoActual = 32;
                            break;
                        case 'u':
                            if (estadoActual == 0) estadoActual = 1;
                            else if (estadoActual == 1) estadoActual = 2;
                            else if (estadoActual == 25) estadoActual = 26;
                            break;
                        case 'v':
                            if (estadoActual == 0) estadoActual = 1;
                            else if (estadoActual == 8) estadoActual = 9;
                            break;
                        case 'w':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'x':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'y':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'z':
                            if (estadoActual == 0) estadoActual = 1;
                            break;


                        ////////////////////////////
                        case 'A':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'B':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'C':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'D':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'E':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'F':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'G':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'H':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'I':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'J':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'K':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'L':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'M':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'N':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'O':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'P':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'Q':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'R':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'S':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'T':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'U':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'V':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'W':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'X':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'Y':
                            if (estadoActual == 0) estadoActual = 1;
                            break;
                        case 'Z':
                            if (estadoActual == 0) estadoActual = 1;
                            break;


                        default:
                            break;
                    }
                }
                //Evaluar la palabra
                if (estadoFinal.Contains(estadoActual))
                    Console.WriteLine("Se acepta la palabra");
                else Console.WriteLine("Se rechaza la palabra");
            }
        }
    }
}