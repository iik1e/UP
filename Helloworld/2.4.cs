using System;

namespace HelloWorld;

class Rome
{
    static void Main()
    {
             int I = 1;
             int V = 5;
              int X = 10;
              int L = 50;
              int C = 100;
              int D = 500;
              int M = 1000;
            
              Console.Write("Римское число -  ");
              string UserNum = Console.ReadLine();
            
              Console.Write("Введите 1 или 2 -  ");
              int choice = int.Parse(Console.ReadLine());

              switch (choice)
              {
                  case 1:
                  {
                      if (UserNum == "IV")
                      {
                          int result;
                          result = V - I;
                          Console.Write(result);
                      }

                      if (UserNum == "IX")
                      {
                          int result;
                          result = X - I;
                          Console.Write(result);
                      }

                      if (UserNum == "XL")
                      {
                          int result;
                          result = L - X;
                          Console.Write(result);
                      }

                      if (UserNum == "XC")
                      {
                          int result;
                          result = C - X;
                          Console.Write(result);
                      }

                      if (UserNum == "CD")
                      {
                          int result;
                          result = D - C;
                          Console.Write(result);
                      }

                      if (UserNum == "CM")
                      {
                          int result;
                          result = M - C;
                          Console.Write(result);
                      }
                      break;
                  }
                  case 2:
                  {
                      int RomanAddition = 0;

                      for (int i = 0; i < UserNum.Length; i++)
                      {
                          switch (UserNum[i])
                          {
                              case 'I':
                              {
                                  RomanAddition += 1;
                                  break;
                              }
                              case 'V':
                              {
                                  RomanAddition += 5;
                                  break;
                              }
                              case 'X':
                              {
                                  RomanAddition += 10;
                                  break;
                              }
                              case 'L':
                              {
                                  RomanAddition += 50;
                                  break;
                              }
                              case 'C':
                              {
                                  RomanAddition += 100;
                                  break;


                              }
                              case 'D':
                              {
                                  RomanAddition += 500;
                                  break;
                              }
                              case 'M':
                              {
                                  RomanAddition += 1000;
                                  break;
                              }
                          }
                      }
                      Console.Write(RomanAddition);
                      break;
    }
    }
    }
}