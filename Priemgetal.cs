
int count = 0;
int number = 1;

while (count < 20)
      {
       bool y = true;

         for (int i = 2; i < number; i++)
          {
             if (number % i == 0)
              {
                    y = false;
                    break;
              }
          }

         if (y)
          {
                Console.Write(number + " ");
                count++;
          }
        number++;
        }
