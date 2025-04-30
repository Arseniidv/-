using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
class Program1 
        { 
        
        
            static void Main()
            {
                int[,,] mas = {
            { { 1, 2 }, { 3, 4 } },
            { { 4, 5 }, { 6, 7 } },
            { { 7, 8 }, { 9, 10 } },
            { { 10, 11 }, { 12, 13 } }
        };

                StringBuilder sb = new StringBuilder("{");

                // Перебор по первому измерению (4 элемента)
                for (int i = 0; i < mas.GetLength(0); i++)
                {
                    sb.Append("{");

                    // Перебор по второму измерению (2 элемента)
                    for (int j = 0; j < mas.GetLength(1); j++)
                    {
                        sb.Append("{");

                        // Перебор по третьему измерению (2 элемента)
                        for (int k = 0; k < mas.GetLength(2); k++)
                        {
                            sb.Append(mas[i, j, k]);
                            if (k < mas.GetLength(2) - 1) sb.Append(" , ");
                        }

                        sb.Append("}");
                        if (j < mas.GetLength(1) - 1) sb.Append(" , ");
                    }

                    sb.Append("}");
                    if (i < mas.GetLength(0) - 1) sb.Append(" , ");
                }

                sb.Append("}");
                Console.WriteLine(sb.ToString());
            }
        }
    }
    
