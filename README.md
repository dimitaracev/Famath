# Famath
Famath е игра за математичари, поточно брзи математичари.
<br>
Целта на Famath е да решите колку повеќе равенки кои со секој левел стануваат потешки.
<br>
Равенките во Famath се состојат од цели позитивни броеви и операторите +, -, *.
<br>
Во Famath постојат 3 тежини (лесно, средно, тешко) со време за секоја равенка (20, 15, 10).
<br>
Famath користи два параметра кои зависат на одбраната тежина, и влијаат врз скорот.
<br>

Пример на функција која генерира равенка и ја враќа како стринг:

```cs
 public String GenerateExpression(int num_range, int multiplier)
        {

            int left = rand.Next(1, num_range * multiplier);
            int right = rand.Next(1, num_range * multiplier);
            char op = operations[rand.Next(0, operations.Length)];

            switch(op)
            {
                case '+':
                    current_answer = left + right;
                    break;
                case '-':
                    current_answer = left - right;
                    break;
                case '*':
                    current_answer = left * right;
                    break;
            }

            return left.ToString() + " " + op + " " + right.ToString();
        }
```
## Contributions
Contributed by Dimitar Acev, 172075.
