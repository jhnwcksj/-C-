using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;

namespace abryaman
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Для номера задачи
            if (comboBox1.SelectedIndex == 0)   // Begin
            {
                richTextBox1.Text = "";
                richTextBox2.Text = "";
                comboBox2.Items.Clear();
                for (int i = 1; i <= 40; i++)
                {
                    comboBox2.Items.Add(i);
                }
            }
            if (comboBox1.SelectedIndex == 1)    // Integer
            {
                richTextBox1.Text = "";
                richTextBox2.Text = "";
                comboBox2.Items.Clear();
                for (int i = 1; i <= 30; i++)
                {
                    comboBox2.Items.Add(i);
                }
            }
            if (comboBox1.SelectedIndex == 2)   // Boolean
            {
                richTextBox1.Text = "";
                richTextBox2.Text = "";
                comboBox2.Items.Clear();
                for (int i = 1; i <= 40; i++)
                {
                    comboBox2.Items.Add(i);
                }
            }
            if (comboBox1.SelectedIndex == 3)   // If
            {   
                richTextBox1.Text = "";
                richTextBox2.Text = "";
                comboBox2.Items.Clear();
                for (int i = 1; i <= 30; i++)
                {
                    comboBox2.Items.Add(i);
                }
            }
            if (comboBox1.SelectedIndex == 4)   // Case
            {
                richTextBox1.Text = "";
                richTextBox2.Text = "";
                comboBox2.Items.Clear();
                for (int i = 1; i <= 20; i++)
                {
                    comboBox2.Items.Add(i);
                }
            }
            if (comboBox1.SelectedIndex == 5)    // For
            {
                richTextBox1.Text = "";
                richTextBox2.Text = "";
                comboBox2.Items.Clear();
                for (int i = 1; i <= 40; i++)
                {
                    comboBox2.Items.Add(i);
                }
            }
            if (comboBox1.SelectedIndex == 6)   // While
            {
                richTextBox1.Text = "";
                richTextBox2.Text = "";
                comboBox2.Items.Clear();
                for (int i = 1; i <= 30; i++)
                {
                    comboBox2.Items.Add(i);
                }
            }
            /*
            if (comboBox1.SelectedIndex == )    // Series
            {
                richTextBox1.Text = "";
                richTextBox2.Text = "";
                comboBox2.Items.Clear();
                for (int i = 1; i <= 40; i++)
                {
                    comboBox2.Items.Add(i);
                }
            }
            if (comboBox1.SelectedIndex == )   // Proc
            {
                richTextBox1.Text = "";
                richTextBox2.Text = "";
                comboBox2.Items.Clear();
                for (int i = 1; i <= 49; i++)
                {
                    comboBox2.Items.Add(i);
                }
            }
            if (comboBox1.SelectedIndex == )   // Minmax
            {
                richTextBox1.Text = "";
                richTextBox2.Text = "";
                comboBox2.Items.Clear();
                for (int i = 1; i <= 30; i++)
                {
                    comboBox2.Items.Add(i);
                }
            }
            */
            if (comboBox1.SelectedIndex == 7)  // Array
            {
                richTextBox1.Text = "";
                richTextBox2.Text = "";
                comboBox2.Items.Clear();
                for (int i = 1; i <= 140; i++)
                {
                    comboBox2.Items.Add(i);
                }
            }
            if (comboBox1.SelectedIndex == 8)  // Matrix
            {
                richTextBox1.Text = "";
                richTextBox2.Text = "";
                comboBox2.Items.Clear();
                for (int i = 1; i <= 100; i++)
                {
                    comboBox2.Items.Add(i);
                }
            }
            if (comboBox1.SelectedIndex == 9)  // String
            {
                richTextBox1.Text = "";
                richTextBox2.Text = "";
                comboBox2.Items.Clear();
                for (int i = 1; i <= 70; i++)
                {
                    comboBox2.Items.Add(i);
                }
            }
            /*
            if (comboBox1.SelectedIndex == )  // File
            {
                richTextBox1.Text = "";
                richTextBox2.Text = "";
                comboBox2.Items.Clear();
                for (int i = 1; i <= 90; i++)
                {
                    comboBox2.Items.Add(i);
                }
            }
            */

            
            

        }


        
            


        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Дано и Решение
            
            if (comboBox1.SelectedIndex == 0)   // Задачи с Begin(1-40)
            {
                switch (comboBox2.SelectedIndex + 1)
                {
                    case 1:
                        richTextBox1.Text = "Дана сторона квадрата a. Найти его периметр P = 4∗a.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {\n    int a, P;\n    cout << \"I must find the Perimeter\" << endl;\n    cout << \"___________________________________________________\" << endl;\n    cout << \"Enter the number please: \";\n    cin >> a;\n    cout << \"___________________________________________________\" << endl;\n    P = a * 4;\n    cout << \"Your Perimeter is: \" << P << endl;\n    cout << \"Congratulation!!!\" << endl;\n}";
                        break;
                    case 2:
                        richTextBox1.Text = "Дана сторона квадрата a. Найти его площадь S = a².";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {\n	int a, b, S;\n	cout << \"Enter a: \";\n	cin >> a;\n	b = 2;\n	S = pow(a, b);\n	cout << \"Your S is: \" << S;\n}";
                        break;
                    case 3:
                        richTextBox1.Text = "Даны стороны прямоугольника a и b. Найти его площадь S = a∗b и периметр P=2∗(a+b).";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {\n	int a, b, S, P;\n	cout << \"Enter a: \";\n	cin >> a;\n	cout << \"Enter b: \";\n	cin >> b;\n	P = 2 * (a + b);\n	S = a * b;\n	cout << \"Your S is: \" << S << endl;\n	cout << \"Your P is: \" << P << endl;\n}";
                        break;
                    case 4:
                        richTextBox1.Text = "Дан диаметр окружности d. Найти ее длину L=π∗d. В качестве значения π использовать 3.14.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {\n	double L, d, p;\n	cout << \"Enter d: \";\n	cin >> d;\n	p = 3.14;\n	L = p * d;\n	cout << \"Your L is: \" << L << endl;\n}";
                        break;
                    case 5:
                        richTextBox1.Text = "Дана длина ребра куба a. Найти объем куба V=a3 и площадь его поверхности S=6∗a².";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {\n	double a, v, V, s, S;\n	cout << \"Enter a: \";\n	cin >> a;\n	v = 3;\n	V = pow(a, v);\n	s = 2;\n	S = 6 * pow(a, s);\n	cout << \"Your V is: \" << V << endl;\n	cout << \"Your S is: \" << S << endl;\n}";
                        break;
                    case 6:
                        richTextBox1.Text = "Даны длины ребер a, b, c прямоугольного параллелепипеда. Найти его объем V=a∗b∗c и площадь поверхности S=2∗(a∗b+b∗c+a∗c).";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {\n	double a, b, c, V, S;\n	cout << \"Enter a: \";\n	cin >> a;\n	cout << \"Enter b: \";\n	cin >> b;\n	cout << \"Enter c: \";\n	cin >> c;\n	V = a * b * c;\n	S = 2 * (a * b + b * c + a * c);\n	cout << \"Your V is: \" << V << endl;\n	cout << \"Your S is: \" << S << endl;\n}";
                        break;
                    case 7:
                        richTextBox1.Text = "Найти длину окружности L и площадь круга S заданного радиуса R:\nL = 2∗π∗R, S = π∗R2.\nВ качестве значения π использовать 3.14.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {\n	double b, R, L, p, S;\n	cout << \"Enter R: \";\n	cin >> R;\n	b = 2;\n	p = 3.14;\n	L = 2 * p * R;\n	S = p * pow(R, b);\n	cout << \"Your L is: \" << L << endl;\n	cout << \"Your S is: \" << S << endl;\n}";
                        break;
                    case 8:
                        richTextBox1.Text = "Даны два числа a и b. Найти их среднее арифметическое: (a+b)/2.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {\n	double a, b, c;\n	cout << \"Enter a: \";\n	cin >> a;\n	cout << \"Enter b: \";\n	cin >> b;\n	c = (a + b) / 2;\n	cout << \"My answer is: \" << c << endl;\n}";
                        break;
                    case 9:
                        richTextBox1.Text = "Даны два неотрицательных числа a и b. Найти их среднее геометрическое, то есть квадратный корень из их произведения: √a·b";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {\n	double a, b, c;\n	cout << \"Enter a: \";\n	cin >> a;\n	cout << \"Enter b: \";\n	cin >> b;\n	c = sqrt(a * b);\n	cout << \"My answer is: \" << c << endl;\n}";
                        break;
                    case 10:
                        richTextBox1.Text = "Даны два ненулевых числа. Найти сумму, разность, произведение и частное их квадратов.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {\n	int a, b, plus, minus, umnozhit;\n	cout << \"Your a is: \";\n	cin >> a;\n	cout << \"Your b is: \";\n	cin >> b;\n	plus = a + b;\n	minus = a - b;\n	umnozhit = a * b;\n	cout << \"a + b = \" << plus << endl;\n	cout << \"a - b = \" << minus << endl;\n	cout << \"a * b = \" << umnozhit << endl;\n	cout << (a * a) / (b * b) << endl;\n}";
                        break;
                    case 11:
                        richTextBox1.Text = "Даны два ненулевых числа. Найти сумму, разность, произведение и частное их модулей.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {\n	int a, b, plus, minus, umnozhit;\n	cout << \"Your a is: \";\n	cin >> a;\n	cout << \"Your b is: \";\n	cin >> b;\n	plus = a + b;\n	minus = a - b;\n	umnozhit = a * b;\n	cout << \"a + b = \" << plus << endl;\n	cout << \"a - b = \" << minus << endl;\n	cout << \"a * b = \" << umnozhit << endl;\n}";
                        break;
                    case 12:
                        richTextBox1.Text = "Даны катеты прямоугольного треугольника a и b. Найти его гипотенузу c и периметр P:\n√a²+b², P = a + b + c.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {\n	int a, b, c, P;\n	cout << \"Your a is: \";\n	cin >> a;\n	cout << \"Your b is: \";\n	cin >> b;\n	c = sqrt(a * a + b * b);\n	P = a + b + c;\n	cout << \"Your Gipotenuza[c] is: \" << c << endl;\n	cout << \"Your P is: \" << P << endl;\n}";
                        break;
                    case 13:
                        richTextBox1.Text = "Даны два круга с общим центром и радиусами R1 и R2 (R1>R2). Найти площади этих кругов S1 и S2, а также площадь S3 кольца, внешний радиус которого равен R1, а внутренний радиус равен R2:\nS1 = π·(R1)2, S2 = π·(R2)2, S3 = S1−S2.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {\n	double R1, R2, p, S1, S2, S3, b;\n	p = 3.14;\n	b = 2;\n	cout << \"Keep in mind that R1 > R2!\" << endl;\n	cout << \"__________________________________________________\" << endl;\n	cout << \"Enter R1: \";\n	cin >> R1;\n	cout << \"Enter R2: \";\n	cin >> R2;\n	S1 = p * pow(R1, b);\n	S2 = p * pow(R2, b);\n	S3 = S1 - S2;\n	if (R1 <= R2) {\n		cout << (\"A blind man has been detected! Try again!\") << endl;\n		cout << \"______________________________________________\";\n	}\n	else {\n		cout << \"Found S3: \" << S3;\n	}\n}";
                        break;
                    case 14:
                        richTextBox1.Text = "Дана длина L окружности. Найти ее радиус R и площадь S круга, ограниченного этой окружностью, учитывая, что L=2∗π∗R, S=π∗R2. В качестве значения π использовать 3.14.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {\n	double L, R, S, p, b;\n	p = 3.14;\n	b = 2;\n	cout << \"Enter L: \";\n	cin >> L;\n	R = L / 2 * p;\n	S = p * pow(R, b);\n	cout << \"R is: \" << R << endl;\n	cout << \"S is: \" << S;\n}";
                        break;
                    case 15:
                        richTextBox1.Text = "Дана площадь S круга. Найти его диаметр D и длину L окружности, ограничивающей этот круг, учитывая, что L=π∗D, S=π∗D2/4. В качестве значения π использовать 3.14.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {\n	double p, b, S, D, L, R;\n	p = 3.14;\n	b = 2;\n	cout << \"Enter S: \";\n	cin >> S;\n	R = sqrt(S / p);\n	L = 2 * p * R;\n	D = L / p;\n	cout << \"L is: \" << L << endl;\n	cout << \"D is: \" << D;\n}";
                        break;
                    case 16:
                        richTextBox1.Text = "Найти расстояние между двумя точками с заданными координатами x1 и x2 на числовой оси: |x2−x1|.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {\n	int x1, x2, c;\n	cout << \"Your x1 is: \";\n	cin >> x1;\n	cout << \"Your x2 is: \";\n	cin >> x2;\n	c = abs(x1 - x2);\n	cout << \"Your module is: \" << c << endl;\n}";
                        break;
                    case 17:
                        richTextBox1.Text = "Даны три точки A, B, C на числовой оси. Найти длины отрезков AC и BC и их сумму.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {\n	double x1, y1, x2, y2, x3, y3, x4, y4, x5, y5;\n	cout << \"Enter coordinate A: \" << endl;\n	cout << \"x1: \";\n	cin >> x1;\n	cout << \"y1: \";\n	cin >> y1;\n	cout << \"_____________________________________\" << endl;\n	cout << \"Enter coordinate B : \" << endl;\n	cout << \"x2: \";\n	cin >> x2;\n	cout << \"y2: \";\n	cin >> y2;\n	cout << \"_____________________________________\" << endl;\n	cout << \"Enter coordinate C : \" << endl;\n	cout << \"x3: \";\n	cin >> x3;\n	cout << \"y3: \";\n	cin >> y3;\n	cout << \"_____________________________________\" << endl;\n	cout << \"Coordinate A: (\" << x1 << \",\" << y1 << \")\" << endl;\n	cout << \"Coordinate B: (\" << x2 << \",\" << y2 << \")\" << endl;\n	cout << \"Coordinate C: (\" << x3 << \",\" << y3 << \")\" << endl;\n	cout << \"_____________________________________\" << endl;\n	x4 = x3 - x1;\n	y4 = y3 - y1;\n	x5 = x3 - x2;\n	y5 = y3 - y2;\n	cout << \"AC coordinate: (\" << x4 << \",\" << y4 << \")\" << endl;\n	cout << \"BC coordinate: (\" << x5 << \",\" << y5 << \")\" << endl;\n}";
                        break;
                    case 18:
                        richTextBox1.Text = "Даны три точки A, B, C на числовой оси. Точка C расположена между точками A и B. Найти произведение длин отрезков AC и BC.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {\n	double x1, y1, x2, y2, x3, y3, x4, y4, x5, y5;\n	cout << \"Enter coordinate A: \" << endl;\n	cout << \"x1: \";\n	cin >> x1;\n	cout << \"y1: \";\n	cin >> y1;\n	cout << \"_____________________________________\" << endl;\n	cout << \"Enter coordinate B : \" << endl;\n	cout << \"x2: \";\n	cin >> x2;\n	cout << \"y2: \";\n	cin >> y2;\n	cout << \"_____________________________________\" << endl;\n	x3 = (x1 + x2) / 2;\n	y3 = (y1 + y2) / 2;\n	cout << \"Coordinate A: (\" << x1 << \",\" << y1 << \")\" << endl;\n	cout << \"Coordinate B: (\" << x2 << \",\" << y2 << \")\" << endl;\n	cout << \"Coordinate C: (\" << x3 << \",\" << y3 << \")\" << endl;\n	cout << \"_____________________________________\" << endl;\n	x4 = x3 - x1;\n	y4 = y3 - y1;\n	x5 = x3 - x2;\n	y5 = y3 - y2;\n	cout << \"AC: (\" << x4 << \",\" << y4 << \")\" << endl;\n	cout << \"BC: (\" << x5 << \",\" << y5 << \")\" << endl;\n}";
                        break;
                    case 19:
                        richTextBox1.Text = "Даны координаты двух противоположных вершин прямоугольника: (x1,y1),  (x2,y2). Стороны прямоугольника параллельны осям координат. Найти периметр и площадь данного прямоугольника.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {\n	int x1, y1, x2, y2, x3, y3, x4, y4, P, S, l1, l2, l3, l4, b;\n	b = 2;\n	cout << \"Keep in mind that x1=x2!\" << endl;\n	cout << \"_____________________________________\" << endl;\n	cout << \"x1:\";\n	cin >> x1;\n	cout << \"y1:\";\n	cin >> y1;\n	cout << \"x2:\";\n	cin >> x2;\n	cout << \"y2:\";\n	cin >> y2;\n	if (x1 == x2) {\n		x3 = -1 * x1;\n		y3 = -1 * y1;\n		x4 = -1 * x2;\n		y4 = -1 * y2;\n		cout << \"_____________________________________\" << endl;\n		cout << \"(x1,y1) = (\" << x1 << \",\" << y1 << \")\" << endl;\n		cout << \"(x2,y2) = (\" << x2 << \",\" << y2 << \")\" << endl;\n		l1 = sqrt(pow(x2 - x1, b) + pow(y2 - y1, b));\n		l2 = sqrt(pow(x3 - x2, b) + pow(y3 - y2, b));\n		l3 = sqrt(pow(x4 - x3, b) + pow(y4 - y3, b));\n		l4 = sqrt(pow(x1 - x4, b) + pow(y1 - y4, b));\n		P = l1 + l2 + l3 + l4;\n		S = l1 * l2;\n		cout << \"_____________________________________\" << endl;\n		cout << \"P: \" << P << endl;\n		cout << \"S: \" << S << endl;\n		cout << \"l1: \" << l1 << endl;\n		cout << \"l2: \" << l2 << endl;\n	}\n	else {\n		cout << \"Try again blind man!\";\n	}\n}";
                        break;
                    case 20:
                        richTextBox1.Text = "Найти расстояние между двумя точками с заданными координатами (x1,y1) и (x2,y2) на плоскости. Расстояние вычисляется по формуле √(x2 — x1)2 + (y2 — y1)2";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {\n	int x1, y1, x2, y2, l, b;\n	b = 2;\n	cout << \"x1:\";\n	cin >> x1;\n	cout << \"y1:\";\n	cin >> y1;\n	cout << \"x2:\";\n	cin >> x2;\n	cout << \"y2:\";\n	cin >> y2;\n	l = sqrt(pow(x2 - x1, b) + pow(y2 - y1, b));\n	cout << \"The distance is: \" << l;\n}";
                        break;
                    case 21:
                        richTextBox1.Text = "Даны координаты трех вершин треугольника: (x1,y1), (x2,y2), (x3,y3). Найти его периметр и площадь, используя формулу для расстояния между двумя точками на плоскости (см. задание Begin20. Для нахождения площади треугольника со сторонами a, b, c использовать формулу Герона:\nS=√p*(p-a)*(p-b)*(p-c)\nгде p = (a+b+c)/2 – полупериметр.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {\n	double x1, y1, x2, y2, x3, y3, p, P, S, a, b, c, d;\n	d = 2;\n	cout << \"x1:\";\n	cin >> x1;\n	cout << \"y1:\";\n	cin >> y1;\n	cout << \"x2:\";\n	cin >> x2;\n	cout << \"y2:\";\n	cin >> y2;\n	cout << \"x3:\";\n	cin >> x3;\n	cout << \"y3:\";\n	cin >> y3;\n	cout << \"_____________________________________\" << endl;\n	a = sqrt(pow(x2 - x1, d) + pow(y2 - y1, d));\n	b = sqrt(pow(x3 - x2, d) + pow(y3 - y2, d));\n	c = sqrt(pow(x1 - x3, d) + pow(y1 - y3, d));\n	cout << \"a: \" << a << endl;\n	cout << \"b: \" << b << endl;\n	cout << \"c: \" << c << endl;\n	cout << \"_____________________________________\" << endl;\n	P = a + b + c;\n	p = (a + b + c) / 2;\n	S = sqrt(p * (p - a) * (p - b) * (p - c));\n	cout << \"P: \" << P << endl;\n	cout << \"S: \" << S << endl;\n}";
                        break;
                    case 22:
                        richTextBox1.Text = "Поменять местами содержимое переменных A и B и вывести новые значения A и B.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {\n	int A, B, C;\n	cout << \"A: \";\n	cin >> A;\n	cout << \"B: \";\n	cin >> B;\n	C = A;\n	A = B;\n	B = C;\n	cout << \"______________________________________________\" << endl;\n	cout << \"A: \" << A << endl;\n	cout << \"B: \" << B << endl;\n}";
                        break;
                    case 23:
                        richTextBox1.Text = "Даны переменные A, B, C. Изменить их значения, переместив содержимое A в B, B — в C, C — в A, и вывести новые значения переменных A, B, C.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {\n	int A, B, C, D;\n	cout << \"A: \";\n	cin >> A;\n	cout << \"B: \";\n	cin >> B;\n	cout << \"C: \";\n	cin >> C;\n	cout << \"______________________________________________\" << endl;\n	D = A;\n	A = C;\n	C = B;\n	B = D;\n	cout << \"A: \" << A << endl;\n	cout << \"B: \" << B << endl;\n	cout << \"C: \" << C << endl;\n}";
                        break;
                    case 24:
                        richTextBox1.Text = "Даны переменные A, B, C. Изменить их значения, переместив содержимое A в C, C — в B, B — в A, и вывести новые значения переменных A, B, C.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {\n	int A, B, C, D;\n	cout << \"Enter your A: \";\n	cin >> A;\n	cout << \"Enter your B: \";\n	cin >> B;\n	cout << \"Enter your C: \";\n	cin >> C;\n	D = A;\n	A = C;\n	C = B;\n	B = D;\n	cout << \"A is: \" << A << endl;\n	cout << \"B is: \" << B << endl;\n	cout << \"C is: \" << C << endl;\n}";
                        break;
                    case 25:
                        richTextBox1.Text = "Найти значение функции y=3∗x6−6∗x2−7 при данном значении x.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {\n	int x, y, a, b;\n	a = 6;\n	b = 2;\n	cout << \"x: \";\n	cin >> x;\n	y = 3 * pow(x, a) - 6 * pow(x, b) - 7;\n	cout << \"______________________________\" << endl;\n	cout << \"y is : \" << y;\n}";
                        break;
                    case 26:
                        richTextBox1.Text = "Найти значение функции y=4∗(x−3)6−7∗(x−3)3+2 при данном значении x.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {\n	int x, y, a, b;\n	a = 6;\n	b = 3;\n	cout << \"x: \";\n	cin >> x;\n	y = 4 * pow(x - 3, a) - 7 * pow(x - 3, b) + 2;\n	cout << \"______________________________\" << endl;\n	cout << \"y is : \" << y;\n}";
                        break;
                    case 27:
                        richTextBox1.Text = "Дано число A. Вычислить A8, используя вспомогательную переменную и три операции умножения. Для этого последовательно находить A2, A4, A8. Вывести все найденные степени числа A.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {	\n	int A, A2, A4, A8;\n	cout << \"A: \";\n	cin >> A;\n	A2 = pow(A, 2);\n	A4 = pow(A, 4);\n	A8 = pow(A, 8);\n	cout << \"______________________________\" << endl;\n	cout << \"A2 is: \" << A2 << endl;\n	cout << \"A4 is: \" << A4 << endl;\n	cout << \"A8 is: \" << A8;\n}";
                        break;
                    case 28:
                        richTextBox1.Text = "Дано число A. Вычислить A15, используя две вспомогательные переменные и пять операций умножения. Для этого последовательно находить A2, A3, A5, A10, A15. Вывести все найденные степени числа A.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {	\n	int A, A2, A3, A5, A10, A15;\n	cout << \"A: \";\n	cin >> A;\n	A2 = pow(A, 2);\n	A3 = pow(A, 3);\n	A5 = pow(A, 5);\n	A10 = pow(A, 10);\n	A15 = pow(A, 15);\n	cout << \"______________________________\" << endl;\n	cout << \"A2 is: \" << A2 << endl;\n	cout << \"A3 is: \" << A3 << endl;\n	cout << \"A5 is: \" << A5 << endl;\n	cout << \"A10 is: \" << A10 << endl;\n	cout << \"A15 is: \" << A15 << endl;\n}";
                        break;
                    case 29:
                        richTextBox1.Text = "Дано значение угла α в градусах (0<α<360). Определить значение этого же угла в радианах, учитывая, что 180o=π радианов. В качестве значения π использовать 3.14.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {	\n	int a;\n	double p, c;\n	p = 3.14;\n	cout << \"Keep in mind that (0 < a < 360)!\" << endl;\n	cout << \"______________________________________\" << endl;\n	cout << \"a (90,180,270): \";\n	cin >> a;\n	if (a < 0) {		cout << \"Try again!\";\n	}\n	else if (a > 360) {		\n		cout << \"Try again!\";\n	}\n	else {		\n		c = a * 3.14 / 180;\n		cout << \"My answer is: \" << c << endl;\n	}\n}";
                        break;
                    case 30:
                        richTextBox1.Text = "Дано значение угла α в радианах (0<α<2π). Определить значение этого же угла в градусах, учитывая, что 180o=π радианов. В качестве значения π использовать 3.14.";
                        richTextBox2.Text = "#include <iostream>\n#include <iomanip>\nusing namespace std;\nint main() {	\n	double alpha;\n	cout << \"alpha: \";\n	cin >> alpha;\n	cout << setprecision(5) << fixed << (alpha * 180) / 3.14;\n}";
                        break;
                    case 31:
                        richTextBox1.Text = "Дано значение температуры T в градусах Фаренгейта. Определить значение этой же температуры в градусах Цельсия. Температура по Цельсию TC и температура по Фаренгейту TF связаны следующим соотношением:\nTC = (TF−32)∗5 / 9.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {	\n	double C, T;\n	cout << \"Enter T: \" << endl;\n	cin >> T;\n	C = (T - 32) * 5 / 9;\n	cout << \"C: \" << C;\n}";
                        break;
                    case 32:
                        richTextBox1.Text = "Дано значение температуры T в градусах Цельсия. Определить значение этой же температуры в градусах Фаренгейта. Температура по Цельсию TC и температура по Фаренгейту TF связаны следующим соотношением:\nTC = (TF−32)∗5 / 9.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {	\n	double C, T;\n	cout << \"Enter C: \";\n	cin >> C;\n	T = C * 9 / 5 + 32;\n	cout << \"T: \" << T;\n}";
                        break;
                    case 33:
                        richTextBox1.Text = "Известно, что X кг конфет стоит A рублей. Определить, сколько стоит 1 кг и Y кг этих же конфет.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {	\n	setlocale(LC_ALL, \"RUS\");\n	int X, A, Y, a;\n	X = 5;\n	A = 100;\n	cout << X << \"кг конфет стоит \" << A << \" рублей\" << endl;\n	cout << \"________________________________________________\" << endl;\n	a = A / X;\n	cout << \"1кг конфет стоит \" << a << \" рублей\" << endl;\n	Y = a * 4;\n	cout << \"4кг конфет стоит \" << Y << \" рублей\" << endl;\n}";
                        break;
                    case 34:
                        richTextBox1.Text = "Известно, что X кг шоколадных конфет стоит A рублей, а Y кг ирисок стоит B рублей. Определить, сколько стоит 1 кг шоколадных конфет, 1 кг ирисок, а также во сколько раз шоколадные конфеты дороже ирисок.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {	\n	setlocale(LC_ALL,\"RUS\");	double X, A, Y, B, a, b, c;\n	cout << \"Примечание: Шоколадный конфет должно быть дороже чем Ирисок!\" << endl;\n	cout << \"Шоколадный конфет: \" << endl;\n	cout << \"Введите кг конфета: \";\n	cin >> X;\n	cout << \"Введите его стоимость: \";\n	cin >> A;\n	cout << \"---------------------------------\" << endl;\n	cout << \"Ирисок: \" << endl;\n	cout << \"Введите кг ирисок: \";\n	cin >> Y;\n	cout << \"Введите его стоимость: \";\n	cin >> B;\n	cout << \"---------------------------------\" << endl;\n	a = A / X;\n	b = B / Y;\n	c = a - b;\n	if (a < b) {		\n		cout << \"Что - то пошло не так!Советую повторить попытку!\";\n	}\n	else {		\n		cout << \"1кг шоколадных конфет стоит: \" << a << endl;\n		cout << \"1кг ирисок стоит: \" << b << endl;\n		cout << \"Шоколадный конфет дороже ирисок на \" << c << \" рублей!\";\n	}\n}";
                        break;
                    case 35:
                        richTextBox1.Text = "Скорость лодки в стоячей воде V км/ч, скорость течения реки U км/ч (U < V). Время движения лодки по озеру T1 ч, а по реке (против течения) T2 ч. Определить путь S, пройденный лодкой (путь = время * скорость). Учесть, что при движении против течения скорость лодки уменьшается на величину скорости течения.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main() {	\n	int v, u, t1, t2;\n	cout << \"v: \";\n	cin >> v;\n	cout << \"u: \";\n	cin >> u;\n	cout << \"t1: \";\n	cin >> t1;\n	cout << \"t2: \";\n	cin >> t2;\n	cout << \"S: \" << v * t1 + (v - u) * t2;\n}";
                        break;
                    case 36:
                        richTextBox1.Text = "Скорость первого автомобиля V1 км/ч, второго — V2 км/ч, расстояние между ними S км. Определить расстояние между ними через T часов, если автомобили удаляются друг от друга. Данное расстояние равно сумме начального расстояния и общего пути, проделанного автомобилями; общий путь = время * суммарная скорость.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main() {	\n	int v1, v2, t, S;\n	cout << \"v1: \";\n	cin >> v1;\n	cout << \"v2: \";\n	cin >> v2;\n	cout << \"t: \";\n	cin >> t;\n	S = (v1 + v2) * t;\n	cout << \"S: \" << S;\n}";
                        break;
                    case 37:
                        richTextBox1.Text = "Скорость первого автомобиля V1 км/ч, второго — V2 км/ч, расстояние между ними S км. Определить расстояние между ними через T часов, если автомобили первоначально движутся навстречу друг другу. Данное расстояние равно модулю разности начального расстояния и общего пути, проделанного автомобилями; общий путь = время * суммарная скорость.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main() {	\n	int v1, v2, t;\n	int d;\n	cout << \"v1: \";\n	cin >> v1;\n	cout << \"v2: \";\n	cin >> v2;\n	cout << \"t: \";\n	cin >> t;\n	d = (v1 + v2) * t;\n	cout << (d >= t ? 0 : t - d);\n}";
                        break;
                    case 38:
                        richTextBox1.Text = "Решить линейное уравнение A∗x+B=0, заданное своими коэффициентами A и B (коэффициент A не равен 0).";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {	\n	double A, B, x;\n	cout << \"A*x + B = 0\" << endl;\n	cout << \"Enter A: \";\n	cin >> A;\n	if (A == 0) {		\n		cout << \"Try again! A must not equal to 0!\" << endl;\n	}\n	else {		\n		cout << \"Enter B: \";\n		cin >> B;\n		x = -B / A;\n		cout << \"x is: \" << x;\n	}\n}";
                        break;
                    case 39:
                        richTextBox1.Text = "Найти корни квадратного уравнения A∗x2+B∗x+C=0, заданного своими коэффициентами A, B, C (коэффициент A не равен 0), если известно, что дискриминант уравнения положителен. Вывести вначале меньший, а затем больший из найденных корней. Корни квадратного уравнения находятся по формуле x1=(−B+√D)/(2∗A),  x2=(−B−√D)/(2∗A), где D — дискриминант, равный B2−4∗A∗C.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\nint main() {	\n	double A, B, C, D, x1, x2;\n	cout << \"A*x2 + B*x + C = 0\" << endl;\n	cout << \"Enter A: \";\n	cin >> A;\n	if (A == 0) {		\n		cout << \"A must not equal to 0!\";\n		return 1;\n	}\n	else {		\n		cout << \"Enter B: \";\n		cin >> B;\n		if (B == 0) {			\n			cout << \"B must not equal to 0!\";\n			return 1;\n		}\n		else {			\n			cout << \"Enter C: \";\n			cin >> C;\n			cout << \"______________________________________\" << endl;\n			cout << A << \"*x2 + \" << B << \"*x + \" << C << \" = 0\" << endl;\n			D = pow(B, 2) - 4 * A * C;\n			if (D <= 0) {				\n				cout << \"There is some mistake! Try again!\";\n			}\n			else {				\n				x1 = (-B + sqrt(D)) / (2 * A);\n				x2 = (-B - sqrt(D)) / (2 * A);\n				cout << \"x1: \" << x1 << endl;\n				cout << \"x2: \" << x2 << endl;\n			}\n		}\n	}\n}";
                        break;
                    case 40:
                        richTextBox1.Text = "Найти решение системы линейных уравнений вида:\nA1*x+B1*y=C1,\nA2*x+B2*y=C2\n\nзаданной своими коэффициентами A1, B1, C1, A2, B2, C2, если известно, что данная система имеет единственное решение.\n\nВоспользоваться формулами:\n\nx = (C1∗B2−C2∗B1)/ D, y = (A1∗C2−A2∗C1)/ D, где D = A1∗B2−A2∗B1.";
                        richTextBox2.Text = "#include <iostream>\n#include <iomanip>\nusing namespace std;\nint main() {	\n	double a1, b1, c1, a2, b2, c2;\n	cout << \"a1: \";\n	cin >> a1;\n	cout << \"b1: \";\n	cin >> b1;\n	cout << \"c1: \";\n	cin >> c1;\n	cout << \"a2: \";\n	cin >> a2;\n	cout << \"b2: \";\n	cin >> b2;\n	cout << \"c2: \";\n	cin >> c2;\n	double d = a1 * b2 - a2 * b2;\n	cout << \"x = \" << setprecision(9) << fixed << (c1 * b2 - c2 * b1) / d << endl;\n	cout << \"y = \" << setprecision(9) << fixed << (a1 * c2 - a2 * c1) / d << endl;\n}";
                        break;
                    default:
                        richTextBox1.Text = "";
                        richTextBox2.Text = "";
                        break;
                }
            }


            if (comboBox1.SelectedIndex == 1)   // Задачи с Integer(1-30)
            {
                switch (comboBox2.SelectedIndex + 1)
                {
                    case 1:
                        richTextBox1.Text = "Дано расстояние L в сантиметрах. Используя операцию деления нацело, найти количество полных метров в нем (1 метр = 100 см).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main() {	\n	int l, m;\n	cout << \"Vvedite L: \";\n	cin >> l;\n	m = int(l / 100);\n	cout << \"Kolichestvo polnyikh metrov: \" << m;\n	return 0;\n}";
                        break;
                    case 2:
                        richTextBox1.Text = "Дана масса M в килограммах. Используя операцию деления нацело, найти количество полных тонн в ней (1 тонна = 1000 кг).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main() {	\n	int M;\n	cout << \"Enter mass: \";\n	cin >> M;\n	M = M / 1000;\n	cout << M;\n}";
                        break;
                    case 3:
                        richTextBox1.Text = "Дан размер файла в байтах. Используя операцию деления нацело, найти количество полных килобайтов, которые занимает данный файл (1 килобайт = 1024 байта).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int byte;\n	cout << \"Enter byte: \";\n	cin >> byte;\n	byte = byte / 1024;\n	cout << byte << \" kbyte\";\n}";
                        break;
                    case 4:
                        richTextBox1.Text = "Даны целые положительные числа A и B (A > B). На отрезке длины A размещено максимально возможное количество отрезков длины B (без наложений). Используя операцию деления нацело, найти количество отрезков B, размещенных на отрезке A.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int A, B;\n	cin >> A >> B;\n	B = A % B;\n	cout << B;\n		\n}";
                        break;
                    case 5:
                        richTextBox1.Text = "Даны целые положительные числа A и B (A > B). На отрезке длины A размещено максимально возможное количество отрезков длины B (без наложений). Используя операцию взятия остатка от деления нацело, найти длину незанятой части отрезка A.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main() {	\n	int A, B;\n	cout << \"(A > B)\" << endl;\n	cout << \"______________________________________\" << endl;\n	cout << \"Enter A: \";\n	cin >> A;\n	cout << \"Enter B: \";\n	cin >> B;\n	cout << A % B;\n}";
                        break;
                    case 6:
                        richTextBox1.Text = "Дано двузначное число. Вывести вначале его левую цифру (десятки), а затем — его правую цифру (единицы). Для нахождения десятков исполь-зовать операцию деления нацело, для нахождения единиц — операцию взятия остатка от деления.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main() {	\n	int n, f, s;\n	cout << \"Vvedite chislo N: \";\n	cin >> n;\n	f = int(n / 10);\n	s = n % 10;\n	cout << \"Desyatki: \" << f << endl;\n	cout << \"Edinitsi: \" << s;\n	return 0;\n}";
                        break;
                    case 7:
                        richTextBox1.Text = "Дано двузначное число. Найти сумму и произведение его цифр.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main() {	\n	int n, f, s;\n	cout << \"Enter the number N: \";\n	cin >> n;\n	f = int(n / 10);\n	s = n % 10;\n	cout << \"Sum of the digits: \" << f + s << endl;\n	cout << \"Product of the digits: \" << f * s;\n	return 0;\n}";
                        break;
                    case 8:
                        richTextBox1.Text = "Дано двузначное число. Вывести число, полученное при перестановке цифр исходного числа.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main() {	\n	int n, f, s, n_new;\n	cout << \"Vvedite chislo N: \";\n	cin >> n;\n	f = int(n / 10);\n	s = n % 10;\n	n_new = s * 10 + f;\n	cout << \"Chislo, poluchennoe v rezul'tate perestanovki cifr iskhodnogo chisla: \" << n_new;\n	return 0;\n}";
                        break;
                    case 9:
                        richTextBox1.Text = "Дано трехзначное число. Используя одну операцию деления нацело, вывести первую цифру данного числа (сотни).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int x;\n	cin >> x;\n	x = x / 100;\n	cout << x;\n}";
                        break;
                    case 10:
                        richTextBox1.Text = "Дано трехзначное число. Вывести вначале его последнюю цифру (единицы), а затем — его среднюю цифру (десятки).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main() {	\n	int n;\n	cout << \"Vvedite chislo N: \";\n	cin >> n;\n	cout << \"Edinitsi: \" << n % 10 << endl;\n	cout << \"Desyatki: \" << int(n / 10) % 10;\n	return 0;\n}";
                        break;
                    case 11:
                        richTextBox1.Text = "Дано трехзначное число. Найти сумму и произведение его цифр.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main() {	\n	int x, a, b, c;\n	cout << \"Enter x(100-999): \";\n	cin >> x;\n	if (x <= 100) {		\n		cout << \"Try again!\";\n		return 0;\n	}\n	else if (x >= 999) {		\n		cout << \"Try again!\";\n		return 0;\n	}\n	else {		\n		a = x / 10;\n		a = a % 10;\n		b = x / 100;\n		c = x % 10;\n		cout << b << \" + \" << a << \" + \" << c << \" = \" << b + a + c;\n	}\n}";
                        break;
                    case 12:
                        richTextBox1.Text = "Дано трехзначное число. Вывести число, полученное при прочтении исходного числа справа налево..";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int x, a, b, c;\n	cin >> x;\n	a = x / 100;\n	b = x % 10;\n	c = x / 10;\n	c = c % 10;\n	cout << b << c << a;\n}";
                        break;
                    case 13:
                        richTextBox1.Text = "Дано трехзначное число. В нем зачеркнули первую слева цифру и приписали ее справа. Вывести полученное число.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int x, a, b, c;\n	cin >> x;\n	a = x / 100;\n	b = x % 10;\n	c = x / 10;\n	c = c % 10;\n	cout << c << b << a;\n}";
                        break;
                    case 14:
                        richTextBox1.Text = "Дано трехзначное число. В нем зачеркнули первую справа цифру и приписали ее слева. Вывести полученное число.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n		\n	int abc, cab;\n	cout << \"Трехзначное число:\";\n	cin >> abc;\n	cout << endl;\n		\n	cab = (abc % 10) * 100 + (abc / 100) * 10 + (abc % 100 / 10);\n	cout << \"Полученное число:\" << cab;\n}";
                        break;
                    case 15:
                        richTextBox1.Text = "Дано трехзначное число. Вывести число, полученное при перестановке цифр сотен и десятков исходного числа (например, 123 перейдет в 213).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int x, a, b, c;\n	cin >> x;\n	a = x / 100;\n	b = x % 10;\n	c = x / 10;\n	c = c % 10;\n	cout << c << a << b;\n}";
                        break;
                    case 16:
                        richTextBox1.Text = "Дано трехзначное число. Вывести число, полученное при перестановке цифр десятков и единиц исходного числа (например, 123 перейдет в 132).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n		\n	int abc, acb;\n	cout << \"Трехзначное число:\";\n	cin >> abc;\n	cout << endl;\n		\n	acb = (abc / 100) * 100 + (abc % 10) * 10 + (abc % 100 / 10);\n	cout << \"Полученное число:\" << acb;\n		\n}";
                        break;
                    case 17:
                        richTextBox1.Text = "Дано целое число, большее 999. Используя одну операцию деления нацело и одну операцию взятия остатка от деления, найти цифру, соответствующую разряду сотен в записи этого числа.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n		\n	int a, b;\n	cout << \"Число больше 999:\";\n	cin >> a;\n	cout << endl;\n		\n	b = a % 1000 / 100;\n	cout << b;\n}";
                        break;
                    case 18:
                        richTextBox1.Text = "Дано целое число, большее 999. Используя одну операцию деления нацело и одну операцию взятия остатка от деления, найти цифру, соответствующую разряду тысяч в записи этого числа.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n		\n	int a, b;\n	cout << \"Число больше 999:\";\n	cin >> a;\n	cout << endl;\n		\n	b = a % 10000 / 1000;\n	cout << \"Тысячи:\" << b;\n}";
                        break;
                    case 19:
                        richTextBox1.Text = "Начала суток прошло N секунд (N — целое). Найти количество полных минут, прошедших с начала суток.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int N;\n	cin >> N;\n	N = N % 86400;\n	N = N % 3600;\n	cout << N;\n}";
                        break;
                    case 20:
                        richTextBox1.Text = "С начала суток прошло N секунд (N — целое). Найти количество полных часов, прошедших с начала суток.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int N;\n	cin >> N;\n	N = N % 86400;\n	N = N % 3600;\n	cout << N;\n}";
                        break;
                    case 21:
                        richTextBox1.Text = "С начала суток прошло N секунд (N — целое). Найти количество секунд, прошедших с начала последней минуты.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n		\n	int N, m;\n	cout << \"Секунды:\";\n	cin >> N;\n	cout << endl;\n		\n	m = N % 60;\n	cout << \"количество секунд, прошедших с начала последней минуты:\" << m;\n}";
                        break;
                    case 22:
                        richTextBox1.Text = "С начала суток прошло N секунд (N — целое). Найти количество се-кунд, прошедших с начала последнего часа.";
                        richTextBox2.Text = "#include <iostream>\n\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"RUS\");\n	int N;\n	int answer;\n	cout << \"Введите количество секунд N: \";\n	cin >> N;\n	answer = N % 3600;\n	cout << \"Количество секунд прошедших с начала последнего часа = \" << answer << endl;\n	return 0;\n}";
                        break;
                    case 23:
                        richTextBox1.Text = "С начала суток прошло N секунд (N — целое). Найти количество полных минут, прошедших с начала последнего часа.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int N;\n	cin >> N;\n	N = N % 3600;\n	N = N % 60;\n	cout << N;\n}";
                        break;
                    case 24:
                        richTextBox1.Text = "Дни недели пронумерованы следующим образом: 0 — воскресенье, 1 — понедельник, 2 — вторник, …, 6 — суббота. Дано целое число K, лежащее в диапазоне 1–365. Определить номер дня недели для K-го дня года, если известно, что в этом году 1 января было понедельником.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main() {	\n	int x;\n	cout << \"Enter x(1-365): \";\n	cin >> x;\n	if (x <= 1) {		\n		cout << \"Try again!\";\n		return 0;\n	}\n	else if (x >= 365) {\n		\n		cout << \"Try again!\";\n		return 0;\n	}\n	else {		\n		cout << x % 7 + 1;\n	}\n}";
                        break;
                    case 25:
                        richTextBox1.Text = "Дни недели пронумерованы следующим образом: 0 — воскресенье, 1 — понедельник, 2 — вторник, …, 6 — суббота. Дано целое число K, лежащее в диапазоне 1–365. Определить номер дня недели для K-го дня года, если известно, что в этом году 1 января было четвергом.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n		\n	int K, m;\n	cout << \"K:\";\n	cin >> K;\n	cout << endl;\n		\n	m = (K + 3) % 7;\n	cout << \"номер дня недели:\" << m;\n}";
                        break;
                    case 26:
                        richTextBox1.Text = "Дни недели пронумерованы следующим образом: 1 — понедельник, 2 — вторник, …, 6 — суббота, 7 — воскресенье. Дано целое число K, лежащее в диапазоне 1–365. Определить номер дня недели для K-го дня года, если известно, что в этом году 1 января было вторником.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int K;\n	cin >> K;\n	K = K % 365 + 2;\n	cout << K;\n}";
                        break;
                    case 27:
                        richTextBox1.Text = "Дни недели пронумерованы следующим образом: 1 — понедельник, 2 — вторник, …, 6 — суббота, 7 — воскресенье. Дано целое число K, лежащее в диапазоне 1–365. Определить номер дня недели для K-го дня года, если известно, что в этом году 1 января было субботой.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n		\n	int K, m;\n	cout << \"K: \";\n	cin >> K;\n	cout << endl;\n		\n	m = ((K + 4) % 7) + 1;\n	cout << \"номер дня недели:\" << m;\n}";
                        break;
                    case 28:
                        richTextBox1.Text = "Дни недели пронумерованы следующим образом: 1 — понедельник, 2 — вторник, …, 6 — суббота, 7 — воскресенье. Дано целое число K, лежащее в диапазоне 1–365, и целое число N, лежащее в диапазоне 1–7. Определить номер дня недели для K-го дня года, если известно, что в этом году 1 января было днем недели с номером N.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {\n	int K, N;\n	cin >> K;\n	cin >> N;\n	K = K % 365 + N;\n	cout << K;\n}";
                        break;
                    case 29:
                        richTextBox1.Text = "Даны целые положительные числа A, B, C. На прямоугольнике размера A × B размещено максимально возможное количество квадратов со стороной C (без наложений). Найти количество квадратов, размещенных на прямоугольнике, а также площадь незанятой части прямоугольника.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"RUS\");\n	int A, B, C, S, a, b;\n	cin >> A >> B >> C;\n	S = A * B;\n	a = S % C;\n	b = (S - a) / C;\n	cout << \"Количество квадратов: \" << b << endl;\n	cout << \"Площадь незанятой части прямоугольника: \" << a;\n}";
                        break;
                    case 30:
                        richTextBox1.Text = "Дан номер некоторого года (целое положительное число). Определить соответствующий ему номер столетия, учитывая, что, к примеру, началом 20 столетия был 1901 год.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    int y; cin >> y;\n    cout << (y + 100) / 100;\n}";
                        break;
                    default:
                        richTextBox1.Text = "";
                        richTextBox2.Text = "";
                        break;

                }
            }


            if (comboBox1.SelectedIndex == 2)   // Задачи с Boolean(1-40)
            {
                switch (comboBox2.SelectedIndex + 1)
                {
                    case 1:
                        richTextBox1.Text = "Дано целое число A. Проверить истинность высказывания: «Число A является положительным».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n		\n	int A;\n	cout << \"Целое число A:\";\n	cin >> A;\n		\n	if (A > 0) {		\n		cout << \"Истинно\";\n	}\n	else {		\n		cout << \"Ложь\";\n	}\n}";
                        break;
                    case 2:
                        richTextBox1.Text = "Дано целое число A. Проверить истинность высказывания: «Число A является нечетным».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n		\n	int A;\n	cout << \"Целое число A:\";\n	cin >> A;\n		\n	if (A % 2) {		\n		cout << \" Истинно\";\n	}\n	else {		\n		cout << \"Ложь\";\n	}\n}";
                        break;
                    case 3:
                        richTextBox1.Text = "Дано целое число A. Проверить истинность высказывания: «Число A является четным».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n		\n	int A;\n	cout << \"Целое число A:\";\n	cin >> A;\n		\n	if (A % 2) {		\n		cout << \"Ложь\";\n	}\n	else {		\n		cout << \"Истинно\";\n	}\n}";
                        break;
                    case 4:
                        richTextBox1.Text = "Даны два целых числа: A, B. Проверить истинность высказывания: «Справедливы неравенства A > 2 и B ≤ 3».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {\n	setlocale(LC_ALL, \"Rus\");\n	int A, B;\n	cout << \"A:\";\n	cin >> A;\n	cout << endl;\n	cout << \"B:\";\n	cin >> B;\n	\n	if (A > 2 && B <= 3) {		\n		cout << \"Истинно\";\n	}\n	else {		\n		cout << \"Ложь\";\n	}\n}";
                        break;
                    case 5:
                        richTextBox1.Text = "Даны два целых числа: A, B. Проверить истинность высказывания: «Справедливы неравенства A ≥ 0 или B < –2».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Rus\");\n	int A, B;\n	cout << \"A:\";\n	cin >> A;\n	cout << endl;\n	cout << \"B:\";\n	cin >> B;\n		\n	if (A >= 0 && B < -2) {		\n		cout << \"Истинно\";\n	}\n	else {		\n		cout << \"Ложь\";\n	}\n}";
                        break;
                    case 6:
                        richTextBox1.Text = "Даны три целых числа: A, B, C. Проверить истинность высказывания: «Справедливо двойное неравенство A < B < C».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Rus\");\n	int A, B, C;\n	cout << \"A:\";\n	cin >> A;\n	cout << \"B:\";\n	cin >> B;\n	cout << \"C:\";\n	cin >> C;\n		\n	if (A < B && B < C) {		\n		cout << \"Истинно\";\n	}\n	else {		\n		cout << \"Ложь\";\n	}\n}";
                        break;
                    case 7:
                        richTextBox1.Text = "Даны три целых числа: A, B, C. Проверить истинность высказывания: «Число B находится между числами A и C».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Rus\");\n	int A, B, C;\n	cout << \"A:\";\n	cin >> A;\n	cout << \"B:\";\n	cin >> B;\n	cout << \"C:\";\n	cin >> C;\n		\n	if (B > A && B < C || B<A && B>C) {		\n		cout << \"Истинно\";\n	}\n	else {		\n		cout << \"Ложь\";\n	}\n}";
                        break;
                    case 8:
                        richTextBox1.Text = "Даны два целых числа: A, B. Проверить истинность высказывания: «Каждое из чисел A и B нечетное».";
                        richTextBox2.Text = "#include <iostream>\n\nusing namespace std;\n\nint main()\n{ \n    int A, B;\n    cout << \"A: \";\n    cin >> A;\n    \n    cout << \"B: \";\n    cin >> B;\n    \n    cout << ((A % 2 != 0) & (B % 2 != 0)) << endl;\n    return 0;\n}";
                        break;
                    case 9:
                        richTextBox1.Text = "Даны два целых числа: A, B. Проверить истинность высказывания: «Хотя бы одно из чисел A и B нечетное».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Rus\");\n	int A, B;\n	cout << \"A:\";\n	cin >> A;\n	cout << \"B:\";\n	cin >> B;\n		\n		\n	if (A % 2 == 0 || B % 2 == 0) {		\n		cout << \"Истинно\";\n	}\n	else {		\n		cout << \"Ложь\";\n	}\n}";
                        break;
                    case 10:
                        richTextBox1.Text = "Даны два целых числа: A, B. Проверить истинность высказывания: «Ровно одно из чисел A и B нечетное».";
                        richTextBox2.Text = "#include <iostream>\n#include <windows.h>\n#include <cmath>\n\nusing namespace std;\n\nint main()\n\n{ \n	SetConsoleCP(1251);\n	SetConsoleOutputCP(1251);\n	\n	int A, B;\n	bool answer;\n	cout << \"Введите число A: \";\n	cin >> A;\n	cout << \"Введите число B: \";\n	cin >> B;\n	answer = A % 2 == 1 && B % 2 == 0 || A % 2 == 0 && B % 2 == 1;\n	answer = (A % 2 + B % 2) == 1;\n	cout << \"Ровно одно из чисел A и B нечетное: \" << boolalpha << answer << endl;\n	\n	system(\"pause\");\n	return 0;\n}";
                        break;
                    case 11:
                        richTextBox1.Text = "Даны два целых числа: A, B. Проверить истинность высказывания: «Числа A и B имеют одинаковую четность».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Rus\");\n	int A, B;\n	cout << \"A:\";\n	cin >> A;\n	cout << \"B:\";\n	cin >> B;\n	if (A % 2 == 0 && B % 2 == 0 || A % 2 != 0 && B % 2 != 0) {		\n		cout << \"Истинно\";\n	}\n	else\n	{ \n		cout << \"Ложь\";\n	}\n}";
                        break;
                    case 12:
                        richTextBox1.Text = "Даны три целых числа: A, B, C. Проверить истинность высказывания: «Каждое из чисел A, B, C положительное».";
                        richTextBox2.Text = "# include <iostream>\n# include <windows.h>\n# include <cmath>\n\nusing namespace std;\n\nint main() {    \n        \n    SetConsoleCP(1251);\n    SetConsoleOutputCP(1251);\n        \n    int A, B, C;\n    bool answer;\n        \n    cout << \"Введите число A: \";\n    cin >> A;\n    cout << \"Введите число B: \";\n    cin >> B;\n    cout << \"Введите число C: \";\n    cin >> C;\n    answer = A > 0 && B > 0 && C > 0;\n    cout << \"Каждое из чисел A, B, C положительное: \" << boolalpha << answer << endl;\n    system(\"pause\");\n    return 0;\n}";
                        break;
                    case 13:
                        richTextBox1.Text = "Даны три целых числа: A, B, C. Проверить истинность высказывания: «Хотя бы одно из чисел A, B, C положительное».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Rus\");\n	int A, B, C;\n	cout << \"A:\";\n	cin >> A;\n	cout << \"B:\";\n	cin >> B;\n	cout << \"C:\";\n	cin >> C;\n		\n		\n	if (A > 0 || B > 0 || C > 0) {		\n		cout << \"Истинно\";\n	}\n	else\n	{ \n		cout << \"Ложь\";\n	}\n}";
                        break;
                    case 14:
                        richTextBox1.Text = "Даны три целых числа: A, B, C. Проверить истинность высказывания: «Ровно одно из чисел A, B, C положительное».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Rus\");\n	int A, B, C;\n	cout << \"A:\";\n	cin >> A;\n	cout << \"B:\";\n	cin >> B;\n	cout << \"C:\";\n	cin >> C;\n		\n		\n	if (A > 0 && B <= 0 && C <= 0 || A <= 0 && B > 0 && C <= 0 || A <= 0 && B <= 0 && C > 0) {		\n		cout << \"Истинно\";\n	}\n	else\n	{ \n		cout << \"Ложь\";\n	}\n}";
                        break;
                    case 15:
                        richTextBox1.Text = "Даны три целых числа: A, B, C. Проверить истинность высказывания: «Ровно два из чисел A, B, C являются положительными».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Rus\");\n	int A, B, C;\n	cout << \"A:\";\n	cin >> A;\n	cout << \"B:\";\n	cin >> B;\n	cout << \"C:\";\n	cin >> C;\n		\n		\n	if (A > 0 && B > 0 && C <= 0 || A <= 0 && B > 0 && C > 0 || A > 0 && B <= 0 && C > 0) {		\n		cout << \"Истинно\";\n	}\n	else\n	{ \n		cout << \"Ложь\";\n	}\n}";
                        break;
                    case 16:
                        richTextBox1.Text = "Дано целое положительное число. Проверить истинность высказывания: «Данное число является четным двузначным».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Rus\");\n	int A;\n	cout << \"A:\";\n	cin >> A;\n	\n		\n		\n	if (A % 2 == 0 && A > 9 && A < 100) {		\n		cout << \"Истинно\";\n	}\n	else\n	{ \n		cout << \"Ложь\";\n	}\n}";
                        break;
                    case 17:
                        richTextBox1.Text = "Дано целое положительное число. Проверить истинность высказы-вания: «Данное число является нечетным трехзначным».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Rus\");\n	int A;\n	cout << \"A:\";\n	cin >> A;\n	if (A % 2 != 0 && A > 99 && A < 1000) {		\n		cout << \"Истинно\";\n	}\n	else\n	{		\n		cout << \"Ложь\";\n	}\n}";
                        break;
                    case 18:
                        richTextBox1.Text = "Дано целое положительное число. Проверить истинность высказы-вания: «Данное число является нечетным трехзначным».";
                        richTextBox2.Text = "# include <iostream>\n\nusing namespace std;\n\nint main() {	\n	int a, b, c;\n	bool answer;\n	cout << \"Введите 3 числа: \" << endl;\n	cout << \"Введите a: \";\n	cin >> a;\n	cout << \"Введите b: \";\n	cin >> b;\n	cout << \"Введите c: \";\n	cin >> c;\n	answer = a == b || a == c || b == c;\n	cout << \"Среди трех данных целых чисел есть хотя бы одна пара совпадающих: \" << boolalpha << answer << endl;\n	return 0;\n}";
                        break;
                    case 19:
                        richTextBox1.Text = "Проверить истинность высказывания: «Среди трех данных целых чисел есть хотя бы одна пара взаимно противоположных».";
                        richTextBox2.Text = "#include <iostream>\n\nusing namespace std;\n\nint main()\n{ \n	int A, B, C;\n	\n	cout << \"A: \";\n	cin >> A;\n	\n	cout << \"B: \";\n	cin >> B;\n	\n	cout << \"C: \";\n	cin >> C;\n	\n	cout << ((A == (-1) * B) | (A == (-1) * C) | (B == (-1) * C)) << endl;\n	return 0;\n}";
                        break;
                    case 20:
                        richTextBox1.Text = "Дано трехзначное число. Проверить истинность высказывания: «Все цифры данного числа различны».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Rus\");\n	int abc, b;\n	cout << \"ABC:\";\n	cin >> abc;\n		\n	if ((abc / 100) != (abc % 100 / 10) && (abc / 100) != (abc % 10) && (abc % 100 / 10) != (abc % 10)) {		\n		cout << \"Истинно\";\n	}\n	else\n	{ \n		cout << \"Ложь\";\n	}\n}";
                        break;
                    case 21:
                        richTextBox1.Text = "Дано трехзначное число. Проверить истинность высказывания: «Цифры данного числа образуют возрастающую последовательность».";
                        richTextBox2.Text = "#include <iostream>\n#include <math.h>\n\nusing namespace std;\n\nint main()\n{ \n	int A;\n	\n	cout << \"A: \";\n	cin >> A;\n	\n	A = fabs(A);\n	cout << (((A / 100) < (A % 100 / 10)) & ((A % 100 / 10) < (A % 10))) << endl;\n	return 0;\n}";
                        break;
                    case 22:
                        richTextBox1.Text = "Дано трехзначное число. Проверить истинность высказывания: «Цифры данного числа образуют возрастающую или убывающую последовательность».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n		\n	int A;\n	cout << \"A:\";\n	cin >> A;\n		\n		\n	if ((A / 100) > (A % 100 / 10) && (A % 100 / 10) > (A % 10) || (A / 100) < (A % 100 / 10) && (A % 100 / 10) < (A % 10)) {		\n		cout << \"Истинно\";\n	}\n	else {		\n		cout << \"Ложь\";\n	}\n}";
                        break;
                    case 23:
                        richTextBox1.Text = "Дано четырехзначное число. Проверить истинность высказывания: «Данное число читается одинаково слева направо и справа налево».";
                        richTextBox2.Text = "#include <iostream>\n#include <math.h>\n\nusing namespace std;\n\nint main(void)\n{ \n    int A;\n    cout << \"A:\";\n    cin >> A;\n    \n    A = abs(A);\n    \n    cout << (A % 10 == A / 1000 & A % 100 / 10 == A % 1000 / 100) << endl;\n    \n    return 0;\n}";
                        break;
                    case 24:
                        richTextBox1.Text = "Даны числа A, B, C (число A не равно 0). Рассмотрев дискриминант D = B2 – 4·A·C, проверить истинность высказывания: «Квадратное уравне-ние A·x2 + B·x + C = 0 имеет вещественные корни».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n		\n	float a, b, c;\n	float D;\n	cout << \"A:\";\n	cin >> a;\n	cout << \"B:\";\n	cin >> b;\n	cout << \"C:\";\n	cin >> c;\n	D = (b * b) - (4 * a * c);\n		\n	if (D >= 0) {		\n		cout << \"Истинно\";\n	}\n	else {		\n		cout << \"Ложь\";\n	}\n}";
                        break;
                    case 25:
                        richTextBox1.Text = "Даны числа x, y. Проверить истинность высказывания: «Точка с ко-ординатами (x, y) лежит во второй координатной четверти».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n		\n	int x, y;\n	cout << \"X:\";\n	cin >> x;\n	cout << \"Y:\";\n	cin >> y;\n		\n	if (x < 0 && y > 0) {		\n		cout << \"Истинно\";\n	}\n	else {		\n		cout << \"Ложь\";\n	}\n}";
                        break;
                    case 26:
                        richTextBox1.Text = "Даны числа x, y. Проверить истинность высказывания: «Точка с ко-ординатами (x, y) лежит в четвертой координатной четверти».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL,\"Russian\");\n		\n	int x, y;\n	cout << \"X:\";\n	cin >> x;\n	cout << \"Y:\";\n	cin >> y;\n		\n	if (x > 0 && y < 0) {		\n		cout << \"Истинно\";\n	}\n	else {		\n		cout << \"Ложь\";\n	}\n}";
                        break;
                    case 27:
                        richTextBox1.Text = "Даны числа x, y. Проверить истинность высказывания: «Точка с координатами (x, y) лежит во второй или третьей координатной четверти».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n		\n	int x, y;\n	cout << \"X:\";\n	cin >> x;\n	cout << \"Y:\";\n	cin >> y;\n		\n	if (x < 0 && y > 0 || x < 0 && y < 0) {		\n		cout << \"Истинно\";\n	}\n	else {		\n		cout << \"Ложь\";\n	}\n}";
                        break;
                    case 28:
                        richTextBox1.Text = "Даны числа x, y. Проверить истинность высказывания: «Точка с координатами (x, y) лежит в первой или третьей координатной четверти».";
                        richTextBox2.Text = "# include <iostream>\n# include <windows.h>\n# include <cmath>\n\nusing namespace std;\n\nint main() {	\n	double x, y;\n	bool answer;\n	cout << \"Введите координаты точки.\" << endl << \"Введите координату x: \";\n	cin >> x;\n	cout << \"Введите координату y: \";\n	cin >> y;\n	answer = x > 0 && y > 0 || x < 0 && y < 0;\n	cout << \"Точка с координатами (x, y) лежит в первой или третьей координатной четверти: \" << boolalpha << answer << endl;\n	return 0;\n}";
                        break;
                    case 29:
                        richTextBox1.Text = "Даны числа x, y, x1, y1, x2, y2. Проверить истинность высказывания: «Точка с координатами (x, y) лежит внутри прямоугольника, левая верхняя вершина которого имеет координаты (x1, y1), правая нижняя — (x2, y2), а стороны параллельны координатным осям».";
                        richTextBox2.Text = "#include <stdio.h>\nint main(void)\n{ \n	float x, y, x1, y1, x2, y2;\n	printf(\"x:\");\n	scanf(\"%f\", &x);\n	printf(\"y:\");\n	scanf(\"%f\", &y);\n	printf(\"x1:\");\n	scanf(\"%f\", &x1);\n	printf(\"y1:\");\n	scanf(\"%f\", &y1);\n	printf(\"x2:\");\n	scanf(\"%f\", &x2);\n	printf(\"y2:\");\n	scanf(\"%f\", &y2);\n	printf(\"%d\n\", x1 < x& x < x2& y2 < y& y < y1);\n	return 0;\n}";
                        break;
                    case 30:
                        richTextBox1.Text = "Даны целые числа a, b, c, являющиеся сторонами некоторого треугольника. Проверить истинность высказывания: «Треугольник со сторонами a, b, c является равносторонним».";
                        richTextBox2.Text = "#include <iostream>\n\nusing namespace std;\n\nint main()\n{ \n	float a, b, c;\n	cout << \"a: \";\n	cin >> a;\n	\n	cout << \"b: \";\n	cin >> b;\n	\n	cout << \"c: \";\n	cin >> c;\n	\n	cout << ((a == b) & (a == c) & (b == c)) << endl;\n	return 0;\n}";
                        break;
                    case 31:
                        richTextBox1.Text = "Даны целые числа a, b, c, являющиеся сторонами некоторого треугольника. Проверить истинность высказывания: «Треугольник со сторонами a, b, c является равнобедренным».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n		\n	int a, b, c;\n	cout << \"A:\";\n	cin >> a;\n	cout << \"B:\";\n	cin >> b;\n	cout << \"C:\";\n	cin >> c;\n		\n	if (a == b || a == c || c == b) {		\n		cout << \"Истинно\";\n	}\n	else {		\n		cout << \"Ложь\";\n	}\n}";
                        break;
                    case 32:
                        richTextBox1.Text = "Даны целые числа a, b, c, являющиеся сторонами некоторого треугольника. Проверить истинность высказывания: «Треугольник со сторонами a, b, c является прямоугольным».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n		\n	int a, b, c;\n	cout << \"A:\";\n	cin >> a;\n	cout << \"B:\";\n	cin >> b;\n	cout << \"C:\";\n	cin >> c;\n		\n	if ((a * a == b * b + c * c) || (b * b == a * a + c * c) || (c * c == a * a + b * b)) {		\n		cout << \"Истинно\";\n	}\n	else {		\n		cout << \"Ложь\";\n	}\n}";
                        break;
                    case 33:
                        richTextBox1.Text = "Даны целые числа a, b, c. Проверить истинность высказывания: «Существует треугольник со сторонами a, b, c».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n		\n	int a, b, c;\n	cout << \"A:\";\n	cin >> a;\n	cout << \"B:\";\n	cin >> b;\n	cout << \"C:\";\n	cin >> c;\n		\n	if ((a + b) > c && (a + c) > b && (b + c) > a) {		\n		cout << \"Истинно\";\n	}\n	else {		\n		cout << \"Ложь\";\n	}\n}";
                        break;
                    case 34:
                        richTextBox1.Text = "Даны координаты поля шахматной доски x, y (целые числа, лежащие в диапазоне 1–8). Учитывая, что левое нижнее поле доски (1, 1) является черным, проверить истинность высказывания: «Данное поле является белым».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n		\n	int x, y;\n	cout << \"X:\";\n	cin >> x;\n	cout << \"Y:\";\n	cin >> y;\n		\n	if ((x + y) % 2 != 0) {		\n		cout << \"Истинно\";\n	}\n	else {		\n		cout << \"Ложь\";\n	}\n}";
                        break;
                    case 35:
                        richTextBox1.Text = "Даны координаты двух различных полей шахматной доски x1, y1, x2, y2 (целые числа, лежащие в диапазоне 1–8). Проверить истинность высказывания: «Данные поля имеют одинаковый цвет».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n		\n	int x1, y1, x2, y2;\n	cout << \"X1:\";\n	cin >> x1;\n	cout << \"Y1:\";\n	cin >> y1;\n	cout << \"X2:\";\n	cin >> x2;\n	cout << \"Y2:\";\n	cin >> y2;\n		\n	if ((x1 + y1) % 2 == (x2 + y2) % 2) {		\n		cout << \"Истинно\";\n	}\n	else {		\n		cout << \"Ложь\";\n	}\n}";
                        break;
                    case 36:
                        richTextBox1.Text = "Даны координаты двух различных полей шахматной доски x1, y1, x2, y2 (целые числа, лежащие в диапазоне 1–8). Проверить истинность высказывания: «Ладья за один ход может перейти с одного поля на другое».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n		\n	int x1, y1, x2, y2;\n	cout << \"X1:\";\n	cin >> x1;\n	cout << \"Y1:\";\n	cin >> y1;\n	cout << \"X2:\";\n	cin >> x2;\n	cout << \"Y2:\";\n	cin >> y2;\n		\n	if (x1 == x2 || y1 == y2) {		\n		cout << \"Истинно\";\n	}\n	else {		\n		cout << \"Ложь\";\n	}\n}";
                        break;
                    case 37:
                        richTextBox1.Text = "Даны координаты двух различных полей шахматной доски x1, y1, x2, y2 (целые числа, лежащие в диапазоне 1–8). Проверить истинность высказывания: «Король за один ход может перейти с одного поля на другое».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n		\n	int x1, y1, x2, y2;\n	cout << \"X1:\";\n	cin >> x1;\n	cout << \"Y1:\";\n	cin >> y1;\n	cout << \"X2:\";\n	cin >> x2;\n	cout << \"Y2:\";\n	cin >> y2;\n		\n	if (abs(x1 - x2) <= 1 && abs(y1 - y2) <= 1) {		\n		cout << \"Истинно\";\n	}\n	else {		\n		cout << \"Ложь\";\n	}\n}";
                        break;
                    case 38:
                        richTextBox1.Text = "Даны координаты двух различных полей шахматной доски x1, y1, x2, y2 (целые числа, лежащие в диапазоне 1–8). Проверить истинность высказывания: «Слон за один ход может перейти с одного поля на другое».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n		\n	int x1, y1, x2, y2;\n	cout << \"X1:\";\n	cin >> x1;\n	cout << \"Y1:\";\n	cin >> y1;\n	cout << \"X2:\";\n	cin >> x2;\n	cout << \"Y2:\";\n	cin >> y2;\n		\n	if (abs(x1 - x2) == abs(y1 - y2) || (x1 == x2) || (y1 == y2)) {		\n		cout << \"Истинно\";\n	}\n	else {		\n		cout << \"Ложь\";\n	}\n}";
                        break;
                    case 39:
                        richTextBox1.Text = "Даны координаты двух различных полей шахматной доски x1, y1, x2, y2 (целые числа, лежащие в диапазоне 1–8). Проверить истинность высказывания: «Ферзь за один ход может перейти с одного поля на другое».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int x1, y1, x2, y2;\n    cout << \"X1:\";\n    cin >> x1;\n    cout << \"Y1:\";\n    cin >> y1;\n    cout << \"X2:\";\n    cin >> x2;\n    cout << \"Y2:\";\n    cin >> y2;\n        \n    if (abs(x1 - x2) == abs(y1 - y2) || (x1 == x2) || (y1 == y2)) {        \n        cout << \"Истинно\";\n    }\n    else {        \n        cout << \"Ложь\";\n    }\n    return 0;\n}";
                        break;
                    case 40:
                        richTextBox1.Text = "Даны координаты двух различных полей шахматной доски x1, y1, x2, y2 (целые числа, лежащие в диапазоне 1–8). Проверить истинность высказывания: «Конь за один ход может перейти с одного поля на другое».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int x1, y1, x2, y2;\n    cout << \"X1:\";\n    cin >> x1;\n    cout << \"Y1:\";\n    cin >> y1;\n    cout << \"X2:\";\n    cin >> x2;\n    cout << \"Y2:\";\n    cin >> y2;\n        \n        \n    if (abs(x1 - x2) == 1 && abs(y1 - y2) == 2 || abs(x1 - x2) == 2 && abs(y1 - y2) == 1) {        \n        cout << \"Истинно\";\n    }\n    else {        \n        cout << \"Ложь\";\n    }\n    return 0;\n}";
                        break;
                    default:
                        richTextBox1.Text = "";
                        richTextBox2.Text = "";
                        break;

                }
            }

            if (comboBox1.SelectedIndex == 3)   // Задачи с If(1-30)
            {
                switch (comboBox2.SelectedIndex + 1)
                {
                    case 1:
                        richTextBox1.Text = "Дано целое число. Если оно является положительным, то прибавить к нему 1; в противном случае не изменять его. Вывести полученное число.";
                        richTextBox2.Text = "#include <iostream>\n\nusing namespace std;\n\nint main()\n{ \n	int a;\n	cout << \"a:\";\n	cin >> a;\n	if (a > 0)a++;\n	cout << a;\n	return 0;\n}";
                        break;
                    case 2:
                        richTextBox1.Text = "Дано целое число. Если оно является положительным, то прибавить к нему 1; в противном случае вычесть из него 2. Вывести полученное число.";
                        richTextBox2.Text = "#include <iostream>\n\nusing namespace std;\n\nint main()\n{ \n    int a;\n    cout << \"a:\";\n    cin >> a;\n    if (a > 0)\n        a++;\n    else\n        a = a - 2;\n    cout << a;\n    return 0;\n}";
                        break;
                    case 3:
                        richTextBox1.Text = "Дано целое число. Если оно является положительным, то прибавить к нему 1; если отрицательным, то вычесть из него 2; если нулевым, то заменить его на 10. Вывести полученное число.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n		\n	int x;\n	cout << \"X:\";\n	cin >> x;\n		\n		\n	if (x > 0) {		\n		x = x++;\n		cout << x;\n	}\n	else {		\n		if (x < 0) {			\n			x = x - 2;\n			cout << x;\n		}\n		else {			\n			x = 10;\n			cout << x;\n		}\n	}\n}";
                        break;
                    case 4:
                        richTextBox1.Text = "Даны три целых числа. Найти количество положительных чисел в исходном наборе.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int a, b, c;\n	cin >> a >> b >> c;\n	if (a > 0) {		\n		cout << a << endl;\n	}\n	if (b > 0) {		\n		cout << b << endl;\n	}\n	if (c > 0) {		\n		cout << c << endl;\n	}\n	else {		\n		cout << \"Try again!\";\n	}\n}";
                        break;
                    case 5:
                        richTextBox1.Text = "Даны три целых числа. Найти количество положительных и количество отрицательных чисел в исходном наборе.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n	int a, b, c, d = 0, k = 0;\n	cout << \"1числo:\";\n	cin >> a;\n	cout << \"2числo:\";\n	cin >> b;\n	cout << \"3числo:\";\n	cin >> c;\n		\n	if (a > 0)\n		d = d++;\n	else\n		k = k++;\n	if (b > 0)\n		d = d++;\n	else\n		k = k++;\n	if (c > 0)\n		d = d++;\n	else\n		k = k++;\n	cout << \"Количество положительных:\" << d << endl << \"Количество отрицательных:\" << k;\n}";
                        break;
                    case 6:
                        richTextBox1.Text = "Даны два числа. Вывести большее из них.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n	int a, b;\n	cout << \"1числo:\";\n	cin >> a;\n	cout << \"2числo:\";\n	cin >> b;\n		\n	if (a > b)\n		cout << a;\n	else\n		cout << b;\n}";
                        break;
                    case 7:
                        richTextBox1.Text = "Даны два числа. Вывести порядковый номер меньшего из них.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n	int a, b;\n	cout << \"1числo:\";\n	cin >> a;\n	cout << \"2числo:\";\n	cin >> b;\n		\n	if (a > b)\n		cout << 2;\n	else\n		cout << 1;\n}";
                        break;
                    case 8:
                        richTextBox1.Text = "Даны два числа. Вывести вначале большее, а затем меньшее из них.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n	int a, b;\n	cout << \"1числo:\";\n	cin >> a;\n	cout << \"2числo:\";\n	cin >> b;\n		\n	if (a > b)\n		cout << a << ' ' << b;\n	else\n		cout << b << ' ' << a;\n}";
                        break;
                    case 9:
                        richTextBox1.Text = "Даны две переменные вещественного типа: A, B. Перераспределить значения данных переменных так, чтобы в A оказалось меньшее из значений, а в B — большее. Вывести новые значения переменных A и B.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n	float a, b;\n	cout << \"1числo:\";\n	cin >> a;\n	cout << \"2числo:\";\n	cin >> b;\n		\n	if (a > b) {		\n		a = a + b;\n		b = a - b;\n		a = a - b;\n		cout << \"a:\" << a << ' ' << \"b:\" << b;\n	}\n	else {		\n		cout << \"a:\" << a << ' ' << \"b:\" << b;\n	}\n}";
                        break;
                    case 10:
                        richTextBox1.Text = "Даны две переменные целого типа: A и B. Если их значения не равны, то присвоить каждой переменной сумму этих значений, а если равны, то присвоить переменным нулевые значения. Вывести новые значения переменных A и B.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int A, B;\n	cin >> A >> B;\n	if (A == B) {		\n		A = 0;\n		B = 0;\n		cout << \"A: \" << A << endl;\n		cout << \"B: \" << B << endl;\n	}\n	else {		\n		cout << \"A + B = \" << A + B;\n	}\n}";
                        break;
                    case 11:
                        richTextBox1.Text = "Даны две переменные целого типа: A и B. Если их значения не равны, то присвоить каждой переменной большее из этих значений, а если равны, то присвоить переменным нулевые значения. Вывести новые значения переменных A и B.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n	int a, b, c;\n	cout << \"1числo:\";\n	cin >> a;\n	cout << \"2числo:\";\n	cin >> b;\n	if (a != b) {		\n		if (a > b) {			\n			c = a + b;\n			a = c - b;\n			b = c - b;\n		}\n		else {			\n			c = a + b;\n			b = c - a;\n			a = c - a;\n		}\n		cout << \"a:\" << a << ' ' << \"b:\" << b;\n	}\n	else {		\n		a = b = 0;\n		cout << \"a:\" << a << ' ' << \"b:\" << b;\n	}\n}";
                        break;
                    case 12:
                        richTextBox1.Text = "Даны три числа. Найти наименьшее из них.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n	int a, b, c;\n	cout << \"1числo:\";\n	cin >> a;\n	cout << \"2числo:\";\n	cin >> b;\n	cout << \"3числo:\";\n	cin >> c;\n		\n	if (a > b && a > c) {		\n		cout << a;\n	}\n	else if (b > a && b > c) {		\n		cout << b;\n	}\n	else if (c > a && c > b) {		\n		cout << c;\n	}\n}";
                        break;
                    case 13:
                        richTextBox1.Text = "Даны три числа. Найти среднее из них (то есть число, расположенное между наименьшим и наибольшим).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n	int a, b, c;\n	cout << \"1числo:\";\n	cin >> a;\n	cout << \"2числo:\";\n	cin >> b;\n	cout << \"3числo:\";\n	cin >> c;\n		\n	if ((b <= a) & (a <= c) || (b >= a) & (a >= c)) {		\n		cout << a;\n	}\n	else {		\n		if ((a <= b) & (b <= c) || (a >= b) & (b >= c)) {			\n			cout << b;\n		}\n		else {			\n			cout << c;\n		}\n	}\n		\n}";
                        break;
                    case 14:
                        richTextBox1.Text = "Даны три числа. Вывести вначале наименьшее, а затем наибольшее из данных чисел.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int A, B, C;\n	cin >> A >> B >> C;\n	if (A < B && B < C && A < C) {		\n		cout << A << endl;\n		cout << C << endl;\n	}\n	else if (B < A && A < C && B < C) {		\n		cout << B << endl;\n		cout << C << endl;\n	}\n	else if (C < A && A < B && C < B) {		\n		cout << C << endl;\n		cout << B << endl;\n	}\n	else if (A < C && C < B && A < B) {		\n		cout << A << endl;\n		cout << B << endl;\n	}\n	else if (B < C && C < A && B < A) {		\n		cout << B << endl;\n		cout << A << endl;\n	}\n	else {		\n		cout << C << endl;\n		cout << A << endl;\n	}\n}";
                        break;
                    case 15:
                        richTextBox1.Text = "Даны три числа. Найти сумму двух наибольших из них.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int A, B, C;\n	cin >> A >> B >> C;\n	if (A < B && B < C && A < C) {		\n		cout << A + C << endl;\n	}\n	else if (B < A && A < C && B < C) {		\n		cout << B + C << endl;\n	}\n	else if (C < A && A < B && C < B) {		\n		cout << C + B << endl;\n	}\n	else if (A < C && C < B && A < B) {		\n		cout << A + B << endl;\n	}\n	else if (B < C && C < A && B < A) {		\n		cout << B + A << endl;\n	}\n	else {		\n		cout << C + A << endl;\n	}\n}";
                        break;
                    case 16:
                        richTextBox1.Text = "Даны три переменные вещественного типа: A, B, C. Если их значения упорядочены по возрастанию, то удвоить их; в противном случае заменить значение каждой переменной на противоположное. Вывести новые значения переменных A, B, C.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n	int a, b, c;\n	cout << \"1числo:\";\n	cin >> a;\n	cout << \"2числo:\";\n	cin >> b;\n	cout << \"3числo:\";\n	cin >> c;\n		\n	if ((a <= b) & (b <= c)) {		\n		a = a * 2;\n		b = b * 2;\n		c = c * 2;\n		cout << \"a:\" << a << ' ' << \"b:\" << b << ' ' << \"c:\" << c;\n	}\n	else {		\n		a = a * (-1);\n		b = b * (-1);\n		c = c * (-1);\n		cout << \"a:\" << a << ' ' << \"b:\" << b << ' ' << \"c:\" << c;\n	}\n}";
                        break;
                    case 17:
                        richTextBox1.Text = "Даны три переменные вещественного типа: A, B, C. Если их значения упорядочены по возрастанию или убыванию, то удвоить их; в противном случае заменить значение каждой переменной на противоположное. Вывести новые значения переменных A, B, C.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int A, B, C;\n	cin >> A >> B >> C;\n	if (A < B && B < C && A < C) {		\n		cout << \"A: \" << A * 2 << endl;\n		cout << \"B: \" << B * 2 << endl;\n		cout << \"C: \" << C * 2 << \"\n\";\n	}\n	else if (A > B && B > C && A > C) {		\n		cout << \"A: \" << A * 2 << endl;\n		cout << \"B: \" << B * 2 << endl;\n		cout << \"C: \" << C * 2 << \"\n\";\n	}\n	else {		\n		cout << \"A: \" << A * -1 << endl;\n		cout << \"B: \" << B * -1 << endl;\n		cout << \"C: \" << C * -1 << endl;\n	}\n}";
                        break;
                    case 18:
                        richTextBox1.Text = "Даны три целых числа, одно из которых отлично от двух других, равных между собой. Определить порядковый номер числа, отличного от остальных.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n	int a, b, c;\n	cout << \"1числo:\";\n	cin >> a;\n	cout << \"2числo:\";\n	cin >> b;\n	cout << \"3числo:\";\n	cin >> c;\n		\n	if (a == b)\n		cout << 3;\n	else if (a == c)\n		cout << 2;\n	else\n		cout << 1;\n}";
                        break;
                    case 19:
                        richTextBox1.Text = "Даны четыре целых числа, одно из которых отлично от трех других, равных между собой. Определить порядковый номер числа, отличного от остальных.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int A, B, C, D;\n	cin >> A >> B >> C >> D;\n	if (A == B && B == C) {		\n		cout << D;\n	}\n	else if (B == C && C == D) {		\n		cout << A << endl;\n	}\n	else if (A == C && C == D) {		\n		cout << B << endl;\n	}\n	else if (A == B && B == D) {		\n		cout << C << endl;\n	}\n	else {		\n		cout << \"Try again!\" << endl;\n	}\n}";
                        break;
                    case 20:
                        richTextBox1.Text = "На числовой оси расположены три точки: A, B, C. Определить, какая из двух последних точек (B или C) расположена ближе к A, и вывести эту точку и ее расстояние от точки A.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Rus\");\n	int A, B, C;\n	cout << \"Введите А: \";\n	cin >> A;\n	cout << \"Введите B: \";\n	cin >> B;\n	cout << \"Введите C: \";\n	cin >> C;\n	if (abs((A - B)) < abs((A - C))) {		\n		cout << \"Точка B ближе точки А на \" << abs(A - B);\n	}\n	else {		\n		cout << \"Точка С ближе точки А на \" << abs(A - C);\n	}\n}";
                        break;
                    case 21:
                        richTextBox1.Text = "Даны целочисленные координаты точки на плоскости. Если точка совпадает с началом координат, то вывести 0. Если точка не совпадает с началом координат, но лежит на оси OX или OY, то вывести соответственно 1 или 2. Если точка не лежит на координатных осях, то вывести 3.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n	setlocale(LC_ALL, \"Ru\");\n	int x, y;\n	cout << \"Даны целочисленные координаты точки на плоскости\" << endl;\n	cin >> x;\n	cin >> y;\n	\n	if (x == 0 && y == 0)\n	{ \n		cout << \"0\" << endl;\n	}\n	else if (x == 0 && y != 0)\n	{ \n		cout << \"1\" << endl;\n	}\n	else if (x != 0 && y == 0)\n	{ \n		cout << \"2\" << endl;\n	}\n	else\n	{ \n		cout << \"3\" << endl;\n	}\n}";
                        break;
                    case 22:
                        richTextBox1.Text = "Даны координаты точки, не лежащей на координатных осях OX и OY. Определить номер координатной четверти, в которой находится данная точка.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int x, y;\n    cout << \"X:\";\n    cin >> x;\n    cout << \"Y:\";\n    cin >> y;\n        \n    if (x > 0 && y > 0) {        \n        cout << \"Первая четверть\";\n    }\n    else if (x < 0 && y>0) {        \n        cout << \"Вторая четверть\";\n    }\n    else if (x < 0 && y < 0) {        \n        cout << \"Третья четверть\";\n    }\n    else\n        cout << \"Четвертая четверть\";\n}";
                        break;
                    case 23:
                        richTextBox1.Text = "Даны целочисленные координаты трех вершин прямоугольника, стороны которого параллельны координатным осям. Найти координаты его четвертой вершины.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int x1, y1, x2, y2, x3, y3;\n    cout << \"Введите x1:\";\n    cin >> x1;\n    cout << \"Введите y1:\";\n    cin >> y1;\n    cout << \"Введите x2:\";\n    cin >> x2;\n    cout << \"Введите y2:\";\n    cin >> y2;\n    cout << \"Введите x3:\";\n    cin >> x3;\n    cout << \"Введите y3:\";\n    cin >> y3;\n    if (x1 == x2) {        \n        cout << \"x4: \" << x3 << endl;\n    }\n    else if (x2 == x3) {        \n        cout << \"x4: \" << x1 << endl;\n    }\n    else if (x1 == x3) {        \n        cout << \"x4: \" << x2 << endl;\n    }\n    else {        \n        cout << \"Try again!\" << endl;\n    }\n    if (y1 == y2) {        \n        cout << \"y4: \" << y3 << endl;\n    }\n    else if (y2 == y3) {        \n        cout << \"y4: \" << y1 << endl;\n    }\n    else if (y1 == y3) {        \n        cout << \"y4: \" << y2 << endl;\n    }\n    else {        \n        cout << \"Try again!\" << endl;\n    }\n}";
                        break;
                    case 24:
                        richTextBox1.Text = "Для данного вещественного x найти значение следующей функции f, принимающей вещественные значения:\nf(x) = 2sin(x), если x > 0,\n         6-x, если x <= 0.";
                        richTextBox2.Text = "# include <iostream>\n# include <windows.h>\n# include <cmath>\n\nusing namespace std;\n\nint main()\n\n{ \n	SetConsoleCP(1251);\n	SetConsoleOutputCP(1251);\n	\n	double x;\n	double f;\n	cout << \"Введите x: \";\n	cin >> x;\n	if (x > 0) f = 2 * sin(x);\n	else f = 6 - x;\n	cout << \"f(x) = \" << f << endl;\n		\n		\n	system(\"pause\");\n	return 0;\n}";
                        break;
                    case 25:
                        richTextBox1.Text = "Для данного целого x найти значение следующей функции f, принимающей значения целого типа:\nf(x) = 2*x, если x < -2 или x > 2,\n         -3*x, в противном случае.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"RU\");\n		\n	int x;\n	cin >> x;\n	\n	if (x > 2 || x < -2) {		\n		cout << 2 * x;\n	}\n	else {		\n		cout << -3 * x;\n	}\n		\n	return 0;\n}";
                        break;
                    case 26:
                        richTextBox1.Text = "Для данного вещественного x найти значение следующей функции f, принимающей вещественные значения:\n         -x, если x <= 0,\nf(x) = x2, если 0 < x < 2,\n         4, если x >= 2.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int x;\n    cout << \"x: \";\n    cin >> x;\n    if (x <= 0) {        \n        cout << \"f(x) = \" << -x;\n    }\n    else if (0 < x && x < 2) {        \n        cout << \"f(x) = \" << pow(x, 2);\n    }\n    else if (x >= 2) {        \n        x = 4;\n        cout << \"f(x) = \" << x;\n    }\n        \n}";
                        break;
                    case 27:
                        richTextBox1.Text = "Для данного вещественного x найти значение следующей функции f, принимающей значения целого типа:\n         0, если x < 0,\nf(x) = 1, если x принадлежит [0,1),[2,3),... ,\n         -1, если x принадлежит [1,2),[3,4),... .";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int x;\n    cout << \"x: \";\n    cin >> x;\n    if (x < 0) {        \n        x = 0;\n        cout << \"f(x): \" << x;\n    }\n    else if (x % 2 == 0 || x != 1) {        \n        x = 1;\n        cout << \"f(x): \" << x;\n    }\n    else if (x % 2 == 1 || x != 0) {        \n        x = -1;\n        cout << \"f(x) = \" << x;\n    }\n        \n}";
                        break;
                    case 28:
                        richTextBox1.Text = "Дан номер года (положительное целое число). Определить количество дней в этом году, учитывая, что обычный год насчитывает 365 дней, а високосный — 366 дней. Високосным считается год, делящийся на 4, за исключением тех годов, которые делятся на 100 и не делятся на 400 (например, годы 300, 1300 и 1900 не являются високосными, а 1200 и 2000 — являются).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int иеар;\n    cout << \"year: \";\n    cin >> иеар;\n    if (иеар % 4 == 0 && иеар % 100 != 0 || иеар % 400 == 0) {        \n        cout << \"Total: \" << иеар * 366 << \" year\";\n    }\n    else {        \n        cout << \"Total: \" << иеар * 365 << \" year\";\n    }\n}";
                        break;
                    case 29:
                        richTextBox1.Text = "Дано целое число. Вывести его строку-описание вида «отрицательное четное число», «нулевое число», «положительное нечетное число» и т. д.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int x;\n    cout << \"Введите число: \";\n    cin >> x;\n    if (x < 0 && x % 2 == 0 || x == -1) {        \n        cout << \"отрицательное четное число!\";\n    }\n    else if (x == 0) {        \n        cout << \"нулевое число!\";\n    }\n    else if (x < 0 && x % 2 == -1) {        \n        cout << \"отричательное нечетное число!\";\n    }\n    else if (x > 0 && x % 2 == 0 || x == 1) {        \n        cout << \"положительное четное число!\";\n    }\n    else if (x > 0 && x % 2 == 1 || x == 1) {        \n        cout << \"положительное нечетное число!\";\n    }\n        \n}";
                        break;
                    case 30:
                        richTextBox1.Text = "Дано целое число, лежащее в диапазоне 1–999. Вывести его строку-описание вида «четное двузначное число», «нечетное трехзначное число» и т. д.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Rus\");\n	int A;\n	cout << \"Enter A(1-999): \";\n	cin >> A;\n	if (A > 1 && A < 999) {		\n		if (A % 2 == 0) {			\n			cout << \"Это Четные числа!\";\n		}\n		else {			\n			cout << \"Это Нечетные числа!\";\n		}\n	}\n	else {		\n		cout << \"Попробуйте еще раз!\";\n	}\n}";
                        break;
                    default:
                        richTextBox1.Text = "";
                        richTextBox2.Text = "";
                        break;
                }
            }

            if (comboBox1.SelectedIndex == 4)   // Задачи с Case(1-20)
            {
                switch (comboBox2.SelectedIndex + 1)
                {
                    case 1:
                        richTextBox1.Text = "Дано целое число в диапазоне 1–7. Вывести строку — название дня не дели, соответствующее данному числу (1 — «понедельник», 2 — «вторник» и т. д.).";
                        richTextBox2.Text = "# include <iostream>\n# include <windows.h>\n# include <cmath>\n\nusing namespace std;\n\nint main()\n\n{ \n    SetConsoleCP(1251);\n    SetConsoleOutputCP(1251);\n\n    int k;\n    cout << \"Введите целое число в диапазоне 1-7:  \";\n    cin >> k;\n    switch (k) {        \n    case 1: cout << \"Понедельник\n\"; break;\n    case 2: cout << \"Вторник\n\"; break;\n    case 3: cout << \"Среда\n\"; break;\n    case 4: cout << \"Четверг\n\"; break;\n    case 5: cout << \"Пятница\n\"; break;\n    case 6: cout << \"Суббота\n\"; break;\n    case 7: cout << \"Воскресенье\n\"; break;\n    default: cout << \"Нет такого дня недели.\n\";\n    }\n\n\n    system(\"pause\");\n    return 0;\n}";
                        break;
                    case 2:
                        richTextBox1.Text = "Дано целое число K. Вывести строку-описание оценки, соответствующей числу K (1 — «плохо», 2 — «неудовлетворительно», 3 — «удовлетворительно», 4 — «хорошо», 5 — «отлично»). Если K не лежит в диапазоне 1–5, то вывести строку «ошибка».";
                        richTextBox2.Text = "#include<iostream>\n#include<cmath>\nusing namespace std;\nint main()\n{ \n    setlocale(LC_ALL, \"Russian\");\n    int k;\n    \n    cout << \"k = \"; cin >> k;\n    \n    switch (k)\n    { \n    case 1: cout << \"плохо\"; break;\n    case 2: cout << \"неудовлетворительно\"; break;\n    case 3: cout << \"удовлетворительно\"; break;\n    case 4: cout << \"хорошо\"; break;\n    case 5: cout << \"отлично\"; break;\n    default: cout << \"ошибка\";\n    }\n        \n    cout << endl << endl;\n        \n    system(\"pause\");\n}";
                        break;
                    case 3:
                        richTextBox1.Text = "Дан номер месяца — целое число в диапазоне 1–12 (1 — январь, 2 февраль и т. д.). Вывести название соответствующего времени года («зима», «весна», «лето», «осень»).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n	int a;\n	cout << \"Число:\";\n	cin >> a;\n		\n	switch (a) {		\n	case 1:\n	case 2:\n	case 12:\n		cout << \"Зима\";\n		break;\n	case 3:\n	case 4:\n	case 5:\n		cout << \"Весна\";\n		break;\n	case 6:\n	case 7:\n	case 8:\n		cout << \"Лето\";\n		break;\n	case 9:\n	case 10:\n	case 11:\n		cout << \"Осень\";\n		break;\n	}\n}";
                        break;
                    case 4:
                        richTextBox1.Text = "Дан номер месяца — целое число в диапазоне 1–12 (1 — январь, 2 февраль и т. д.). Определить количество дней в этом месяце для невисокосного года.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n	int a;\n	cout << \"Число:\";\n	cin >> a;\n		\n	switch (a) {		\n	case 1:\n	case 3:\n	case 5:\n	case 7:\n	case 8:\n	case 10:\n	case 12:\n		cout << \"В месяце 31 днень\";\n		break;\n	case 4:\n	case 6:\n	case 9:\n	case 11:\n		cout << \"В месяце 30 днень\";\n		break;\n	case 2:\n		cout << \"В месяце 28 днень\";\n		break;\n	}\n}";
                        break;
                    case 5:
                        richTextBox1.Text = "Арифметические действия над числами пронумерованы следующим образом: 1 — сложение, 2 — вычитание, 3 — умножение, 4 — деление. Дан номер действия N (целое число в диапазоне 1–4) и вещественные числа A и B (B не равно 0). Выполнить над числами указанное действие и вывести результат.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int N, A, B;\n    cout << \"1 - сложение(+) \n2 - вычитание(-) \n3 - умножение(*) \n4 - деление(/) \n___________________________________________________________________ \n\";\n    cout << \"Введите номер действия: \";\n    cin >> N;\n    cout << \"A: \";\n    cin >> A;\n    cout << \"B(B не равно 0!): \";\n    cin >> B;\n    if (B == 0) {        \n        cout << \"Попробуйте POPITку!\";\n    }\n    else {        \n        switch (N) {            \n        case 1:\n            cout << A + B;\n            break;\n        case 2:\n            cout << A - B;\n            break;\n        case 3:\n            cout << A * B;\n            break;\n        case 4:\n            cout << A / B;\n            break;\n        }\n    }\n}";
                        break;
                    case 6:
                        richTextBox1.Text = "Единицы длины пронумерованы следующим образом: 1 — дециметр, 2 — километр, 3 — метр, 4 — миллиметр, 5 — сантиметр. Дан номер единицы длины (целое число в диапазоне 1–5) и длина отрезка в этих единицах (вещественное число). Найти длину отрезка в метрах.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Russian\");\n	int N, b;\n	cout << \"Номер действия:\";\n	cin >> N;\n	cout << \"Длинна:\";\n	cin >> b;\n		\n		\n	switch (N) {		\n	case 1:\n		cout << b / 10;\n		break;\n	case 2:\n		cout << b * 1000;\n		break;\n	case 3:\n		cout << b;\n		break;\n	case 4:\n		cout << b / 1000;\n		break;\n	case 5:\n		cout << b / 100;\n		break;\n	}\n}";
                        break;
                    case 7:
                        richTextBox1.Text = "Единицы массы пронумерованы следующим образом: 1 — килограмм, 2 — миллиграмм, 3 — грамм, 4 — тонна, 5 — центнер. Дан номер единицы массы (целое число в диапазоне 1–5) и масса тела в этих единицах (вещественное число). Найти массу тела в килограммах.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int N, A;\n    cout << \"1 - килограмм \n2 - миллиграмм \n3 - грамм \n4 - тонна \n5 - центнер \n___________________________________________________________________ \n\";\n    cout << \"Введите номер единицы массы: \";\n    cin >> N;\n    cout << \"A: \";\n    cin >> A;\n    switch (N) {        \n    case 1:\n        cout << A;\n        break;\n    case 2:\n        cout << A / 1000000;\n        break;\n    case 3:\n        cout << A / 1000;\n        break;\n    case 4:\n        cout << A * 1000;\n        break;\n    case 5:\n        cout << A * 100;\n        break;\n    }\n}";
                        break;
                    case 8:
                        richTextBox1.Text = "Даны два целых числа: D (день) и M (месяц), определяющие правильную дату невисокосного года. Вывести значения D и M для даты, предшествующей указанной.";
                        richTextBox2.Text = "#include<iostream>\nusing namespace std;\n\nint _tmain(int argc, _TCHAR* argv[])\n{ \n	setlocale(0, \"Rus\");\n	int D, M;\n	std::cout << \"Введите день:\";\n	std::cin >> D;\n	std::cout << \"Введите номер месяца:\";\n	std::cin >> M;\n	D = D - 1;\n	if (D == 0) {		\n		M = M - 1;\n		if (M = 0) {			\n			M = 12;\n		}\n		switch (M)\n		{ \n		case 1: D = 31;\n		case 3: D = 31;\n		case 5: D = 31;\n		case 7: D = 31;\n		case 8: D = 31;\n		case 10: D = 31;\n		case 12: D = 31;\n		case 4: D = 30;\n		case 6: D = 30;\n		case 9: D = 30;\n		case 11: D = 30;\n		case 2: D = 28;\n		}\n	}\n	std::cout << \"Предыдущая дата:\" << D << \".\" << M;\n	return 0;\n}";
                        break;
                    case 9:
                        richTextBox1.Text = "Даны два целых числа: D (день) и M (месяц), определяющие правильную дату невисокосного года. Вывести значения D и M для даты, следующей за указанной.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main()\n{ \n	int d, m;\n	cin >> d >> m;\n	d++;\n	switch (d)\n	{		\n	case 32:d = 1;++m;\n		switch (m)\n		{ \n		case 1:\n		case 3:\n		case 5:\n		case 7:\n		case 8:\n		case 10:\n			d = 31;break;\n		case 13:d = 1;m = 1;break;\n			break;\n		} break;\n	case 29:d = 1;++m;\n		switch (m)\n		{ \n		case 2:d = 28;break;\n		}break;\n	case 31:d = 1;++m;\n		switch (m)\n		{ \n		case 4:\n		case 6:\n		case 9:\n		case 11:\n			d = 30;break;\n		case 12:d = 1;m = 1;break;\n		}\n	}\n		\n	cout << d << \" \" << m;\n	return 0;\n}";
                        break;
                    case 10:
                        richTextBox1.Text = "Робот может перемещаться в четырех направлениях («С» — север, «З» — запад, «Ю» — юг, «В» — восток) и принимать три цифровые команды: 0 — продолжать движение, 1 — поворот налево, –1 — поворот направо. Дан символ C — исходное направление робота и целое число N — посланная ему команда. Вывести направление робота после выполнения полученной команды.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int N;\n    char C;\n    cout << \"C - север \nЗ - запад \nЮ - юг \nВ - восток \n___________________________________________________________________ \n\";\n    cout << \"Введите направление робота(только русскими буквами!): \";\n    cin >> C;\n    cout << \"N(-1,0,1): \";\n    cin >> N;\n    switch (C) {        \n    case \'С\':\n        switch (N) {            \n        case 1:\n            C = \'З\';\n            break;\n        case 0:\n            C = \'С\';\n            break;\n        case -1:\n            C = \'B\';\n            break;\n        }\n        break;\n    case \'З\':\n        switch (N) {            \n        case 1:\n            C = \'Ю\';\n            break;\n        case 0:\n            C = \'З\';\n            break;\n        case -1:\n            C = \'С\';\n            break;\n        }\n        break;\n    case \'Ю\':\n        switch (N) {            \n        case 1:\n            C = \'В\';\n            break;\n        case 0:\n            C = \'Ю\';\n            break;\n        case -1:\n            C = \'З\';\n            break;\n        }\n        break;\n    case \'В\':\n        switch (N) {            \n        case 1:\n            C = \'С\';\n            break;\n        case 0:\n            C = \'В\';\n            break;\n        case -1:\n            C = \'Ю\';\n            break;\n        }\n        break;\n    }\n    cout << \"Направление идет на \" << C;\n}";
                        break;
                    case 11:
                        richTextBox1.Text = "Локатор ориентирован на одну из сторон света («С» — север, «З» — запад, «Ю» — юг, «В» — восток) и может принимать три цифровые команды поворота: 1 — поворот налево, –1 — поворот направо, 2 — поворот на 180^o. Дан символ C — исходная ориентация локатора и целые числа N_1 и N_2 — две посланные команды. Вывести ориентацию локатора после выполнения этих команд.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Rus\");\n	char C;\n	int n1, n2;\n	cout << \"Введите локатор(С): \";\n	cin >> C;\n	cout << \"Введите 1-поворот: \";\n	cin >> n1;\n	cout << \"Введите 2-поворот: \";\n	cin >> n2;\n	switch (C) {		\n	case \'С\':\n		switch (n1 + n2) {			\n		case -1:\n		case 3:\n			C = \'В\';\n			break;\n		case 1:\n			C = \'З\';\n			break;\n		case -2:\n		case 2:\n			C = \'Ю\';\n			break;\n				\n		}\n		break;\n	case \'В\':\n		switch (n1 + n2) {			\n		case -1:\n		case 3:\n			C = \'Ю\';\n			break;\n		case 1:\n			C = \'С\';\n			break;\n		case -2:\n		case 2:\n			C = \'З\';\n			break;\n		}\n		break;\n	case \'Ю\':\n		switch (n1 + n2) {			\n		case -1:\n		case 3:\n			C = \'З\';\n			break;\n		case 1:\n			C = \'В\';\n			break;\n		case -2:\n		case 2:\n			C = \'С\';\n			break;\n		}\n		break;\n	case \'З\':\n		switch (n1 + n2) {			\n		case -1:\n		case 3:\n			C = \'С\';\n			break;\n		case 1:\n			C = \'Ю\';\n			break;\n		case -2:\n		case 2:\n			C = \'В\';\n			break;\n		}\n	}\n	cout << C;\n}";
                        break;
                    case 12:
                        richTextBox1.Text = "Элементы окружности пронумерованы следующим образом: 1 — радиус R, 2 — диаметр D=2*R, 3 — длина L=2*π*R, 4 — площадь круга S =π*R2. Дан номер одного из этих элементов и его значение. Вывести значения остальных элементов данной окружности (в том же порядке). В качестве значения π использовать 3.14.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main() {	\n	int n;\n	float const π = 3.14;\n	float x, R, D, L, S;\n	cin >> n;\n	cin >> x;\n	switch (n) {		\n	case 1:\n		R = x;\n		D = 2 * R;\n		L = 2 * 3.14 * R;\n		S = 3.14 * (R * R);\n		cout << \"D=\" << D << endl;\n		cout << \"L=\" << L << endl;\n		cout << \"S=\" << S << endl; break;\n	case 2:\n		R = x / 2;\n		D = x;\n		L = 2 * 3.14 * R;\n		S = 3.14 * (R * R);\n		cout << \"R=\" << R << endl;\n		cout << \"L=\" << L << endl;\n		cout << \"S=\" << S << endl; break;\n	case 3:\n		R = x / 2 * 3.14;\n		D = 2 * R;\n		L = x;\n		S = 3.14 * (R * R);\n		cout << \"R=\" << R << endl;\n		cout << \"D=\" << D << endl;\n		cout << \"S=\" << S << endl; break;\n	case 4:\n		R = sqrt(x / 3.14);\n		D = 2 * R;\n		L = 2 * 3.14 * R;\n		S = x;\n		cout << \"R=\" << R << endl;\n		cout << \"D=\" << D << endl;\n		cout << \"L=\" << L << endl; break;\n	}\n	return 0;\n}";
                        break;
                    case 13:
                        richTextBox1.Text = "Элементы равнобедренного прямоугольного треугольника пронумерованы следующим образом: 1 — катет a, 2 — гипотенуза c = a*√2 , 3 — высота h, опущенная на гипотенузу (h=c/2), 4 — площадь S = c*h/2. Дан номер одного из этих элементов и его значение. Вывести значения остальных элементов данного треугольника (в том же порядке).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int n;\n    float x, a, c, h, s;\n    cout << \"Номер элемента:\";\n    cin >> n;\n    cout << \"Длинна:\";\n    cin >> x;\n        \n    switch (n) {        \n    case 1:\n        a = x;\n        c = a * sqrt(2);\n        h = c / 2;\n        s = c * h / 2;\n        cout << c << h << s;\n        break;\n    case 2:\n        c = x;\n        a = c / sqrt(2);\n        h = c / 2;\n        s = c * h / 2;\n        cout << a << h << s;\n        break;\n    case 3:\n        h = x;\n        c = 2 * h;\n        a = c / sqrt(2);\n        s = c * h / 2;\n        cout << a << c << s;\n        break;\n    case 4:\n        s = x;\n        h = sqrt(s);\n        c = 2 * h;\n        a = c / sqrt(2);\n        cout << a << c << h;\n        break;\n    }\n    return 0;\n}";
                        break;
                    case 14:
                        richTextBox1.Text = "Элементы равностороннего треугольника пронумерованы следующим образом: 1 — сторона a, 2 — радиус R_1 вписанной окружности (R1 = a√3/6 ), 3 — радиус R2 описанной окружности (R2 = 2*R1), 4 — площадь S = a2√3 / 4 . Дан номер одного из этих элементов и его значение. Вывести значения остальных элементов данного треугольника (в том же порядке).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int R1, R2, S, a, N;\n    cout << \"Номер элемента: \";\n    cin >> N;\n    cout << \"a: \";\n    cin >> a;\n    switch (N) {\n    case 1:\n        cout << a;\n        break;\n    case 2:\n        R1 = a * sqrt(3) / 6;\n        cout << \"R1: \" << R1;\n        break;\n    case 3:\n        R1 = a * sqrt(3) / 6;\n        R2 = 2 * R1;\n        cout << \"R2: \" << R2;\n        break;\n    case 4:\n        S = pow(a, 2) * sqrt(3) / 4;\n        cout << \"S: \" << S;\n        break;\n    }\n}";
                        break;
                    case 15:
                        richTextBox1.Text = "Мастям игральных карт присвоены порядковые номера: 1 — пики, 2 — трефы, 3 — бубны, 4 — червы. Достоинству карт, старших десятки, присвоены номера: 11 — валет, 12 — дама, 13 — король, 14 — туз. Даны два целых числа: N — достоинство (6 ≤ N ≤ 14) и M — масть карты (1 ≤ M ≤ 4). Вывести название соответствующей карты вида «шестерка бубен», «дама червей», «туз треф» и т. п.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Rus\");\n	int N, M;\n	cout << \"Введите N (6-14): \";\n	cin >> N;\n	cout << \"Введите M (1-4): \";\n	cin >> M;\n	switch (N) {		\n	case 6:\n		cout << \"Шестерка \";\n		break;\n	case 7:\n		cout << \"Семерка \";\n		break;\n	case 8:\n		cout << \"Восьмерка \";\n		break;\n	case 9:\n		cout << \"Девятка \";\n		break;\n	case 10:\n		cout << \"Десятка \";\n		break;\n	case 11:\n		cout << \"Валет \";\n		break;\n	case 12:\n		cout << \"Дама \";\n		break;\n	case 13:\n		cout << \"Король \";\n		break;\n	case 14:\n		cout << \"Туз \";\n		break;\n	}\n	switch (M) {		\n	case 1:\n		cout << \"пики\";\n		break;\n	case 2:\n		cout << \"трефы\";\n		break;\n	case 3:\n		cout << \"бубны\";\n		break;\n	case 4:\n		cout << \"червы\";\n		break;\n	}\n}";
                        break;
                    case 16:
                        richTextBox1.Text = "Дано целое число в диапазоне 20–69, определяющее возраст (в годах). Вывести строку-описание указанного возраста, обеспечив правильное согласование числа со словом «год», например: 20 — «двадцать лет», 32 — «тридцать два года», 41 — «сорок один год».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Rus\");\n    int Y;\n    cout << \"Enter year: \";\n    cin >> Y;\n    if (20 < Y && Y < 69) {        \n        switch (Y / 10) {            \n        case 2:\n            cout << \"двадцать \";\n            break;\n        case 3:\n            cout << \"тридцать \";\n            break;\n        case 4:\n            cout << \"сорок \";\n            break;\n        case 5:\n            cout << \"пятьдесят \";\n            break;\n        case 6:\n            cout << \"шестьдесят \";\n            break;\n        }\n        switch (Y % 10) {            \n        case 1:\n            cout << \"один \";\n            break;\n        case 2:\n            cout << \"два \";\n            break;\n        case 3:\n            cout << \"три \";\n            break;\n        case 4:\n            cout << \"четыре \";\n            break;\n        case 5:\n            cout << \"пять \";\n            break;\n        case 6:\n            cout << \"шесть \";\n            break;\n        case 7:\n            cout << \"семь \";\n            break;\n        case 8:\n            cout << \"восемь \";\n            break;\n        case 9:\n            cout << \"девять \";\n            break;\n        }\n        switch (Y % 10) {            \n        case 1:\n            cout << \"год\";\n            break;\n        case 2:\n        case 3:\n        case 4:\n            cout << \"года\";\n            break;\n        case 5:\n        case 6:\n        case 7:\n        case 8:\n        case 9:\n            cout << \"лет\";\n            break;\n        }\n    }\n    else {        \n        cout << \"Try again!\";\n    }\n}";
                        break;
                    case 17:
                        richTextBox1.Text = "Дано целое число в диапазоне 10–40, определяющее количество учебных заданий по некоторой теме. Вывести строку-описание указанного количества заданий, обеспечив правильное согласование числа со словами «учебное задание», например: 18 — «восемнадцать учебных заданий», 23 — «двадцать три учебных задания», 31 — «тридцать одно учебное задание».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Rus\");\n    int a;\n    cout << \"Enter word: \";\n    cin >> a;\n    if (40 >= a && a >= 10) {        \n        if (a / 10 == 1)\n            switch (a) {                \n            case 10:\n                cout << \"десять учебных заданий.\";\n                break;\n            case 11:\n                cout << \"одинадцать учебных заданий.\";\n                break;\n            case 12:\n                cout << \"двенадцать учебных заданий.\";\n                break;\n            case 13:\n                cout << \"тринадцать учебных заданий.\";\n                break;\n            case 14:\n                cout << \"четырнадцать учебных заданий.\";\n                break;\n            case 15:\n                cout << \"пятнадцать учебных заданий.\";\n                break;\n            case 16:\n                cout << \"шестнадцать учебных заданий.\";\n                break;\n            case 17:\n                cout << \"семнадцать учебных заданий.\";\n                break;\n            case 18:\n                cout << \"восемнадцать учебных заданий.\";\n                break;\n            case 19:\n                cout << \"девятнадцать учебных заданий.\";\n                break;\n            }\n        else {            \n            switch (a / 10) {                \n            case 2:\n                cout << \"двадцать \";\n                break;\n            case 3:\n                cout << \"тридцать \";\n                break;\n            case 4:\n                cout << \"сорок \";\n                break;\n            }\n                \n            switch (a % 10) {                \n            case 1:\n                cout << \"одно \";\n                break;\n            case 2:\n                cout << \"два \";\n                break;\n            case 3:\n                cout << \"три \";\n                break;\n            case 4:\n                cout << \"четыре \";\n                break;\n            case 5:\n                cout << \"пять \";\n                break;\n            case 6:\n                cout << \"шесть \";\n                break;\n            case 7:\n                cout << \"семь \";\n                break;\n            case 8:\n                cout << \"восемь \";\n                break;\n            case 9:\n                cout << \"девять \";\n                break;\n            }\n                \n            switch (a % 10) {                \n            case 0:\n            case 5:\n            case 6:\n            case 7:\n            case 8:\n            case 9:\n                cout << \"учебных заданий.\";\n                break;\n            case 1:\n                cout << \"учебное задание.\";\n                break;\n            case 2:\n            case 3:\n            case 4:\n                cout << \"учебных задания.\";\n                break;\n            }\n        }\n    }\n    else {    \n        cout << \"Try again!\";\n    }\n}";
                        break;
                    case 18:
                        richTextBox1.Text = "Дано целое число в диапазоне 100–999. Вывести строку-описание данного числа, например: 256 — «двести пятьдесят шесть», 814 — «восемьсот четырнадцать».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Rus\");\n    int N;\n    cout << \"N:\";\n    cin >> N;\n    if (100 < N && N < 999) {        \n        switch (N / 100) {            \n        case 1:\n            cout << \"сто \";\n            break;\n        case 2:\n            cout << \"двести \";\n            break;\n        case 3:\n            cout << \"триста \";\n            break;\n        case 4:\n            cout << \"четыреста \";\n            break;\n        case 5:\n            cout << \"пятьсот \";\n            break;\n        case 6:\n            cout << \"шестьсот \";\n            break;\n        case 7:\n            cout << \"семьсот \";\n            break;\n        case 8:\n            cout << \"восемьсот  \";\n            break;\n        case 9:\n            cout << \"девятьсот  \";\n            break;\n        }\n        if ((N % 100) / 10 == 1)\n            switch (N % 100) {                \n            case 10:\n                cout << \"десять\";\n                break;\n            case 11:\n                cout << \"одинадцать\";\n                break;\n            case 12:\n                cout << \"двенадцать\";\n                break;\n            case 13:\n                cout << \"тринадцать\";\n                break;\n            case 14:\n                cout << \"четырнадцать\";\n                break;\n            case 15:\n                cout << \"пятнадцать\";\n                break;\n            case 16:\n                cout << \"шестнадцать\";\n                break;\n            case 17:\n                cout << \"семнадцать\";\n                break;\n            case 18:\n                cout << \"восемнадцать\";\n                break;\n            case 19:\n                cout << \"девятнадцать\";\n                break;\n            }\n        else {            \n            switch ((N % 100) / 10) {                \n            case 2:\n                cout << \"двадцать \";\n                break;\n            case 3:\n                cout << \"тридцать \";\n                break;\n            case 4:\n                cout << \"сорок \";\n                break;\n            case 5:\n                cout << \"пятьдесят \";\n                break;\n            case 6:\n                cout << \"шестьдесят \";\n                break;\n            case 7:\n                cout << \"семьдесят \";\n                break;\n            case 8:\n                cout << \"восемьдесят \";\n                break;\n            case 9:\n                cout << \"девяносто \";\n                break;\n            }\n            switch (N % 10) {                \n            case 1:\n                cout << \"один\";\n                break;\n            case 2:\n                cout << \"два\";\n                break;\n            case 3:\n                cout << \"три\";\n                break;\n            case 4:\n                cout << \"четыре\";\n                break;\n            case 5:\n                cout << \"пять\";\n                break;\n            case 6:\n                cout << \"шесть\";\n                break;\n            case 7:\n                cout << \"семь\";\n                break;\n            case 8:\n                cout << \"восемь\";\n                break;\n            case 9:\n                cout << \"девять\";\n                break;\n            }\n        }\n    }\n    else {    \n        cout << \"Try again!\";\n    }\n}";
                        break;
                    case 19:
                        richTextBox1.Text = "В восточном календаре принят 60-летний цикл, состоящий из 12-летних подциклов, обозначаемых названиями цвета: зеленый, красный, желтый, белый и черный. В каждом подцикле годы носят названия животных: крысы, коровы, тигра, зайца, дракона, змеи, лошади, овцы, обезьяны, курицы, собаки и свиньи. По номеру года определить его название, если 1984 год — начало цикла: «год зеленой крысы».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Rus\");\n    int a;\n    cout << \"Введите год: \";\n    cin >> a;\n    cout << \"год \";\n    switch ((a) % 10) {        \n    case 0:\n    case 1:\n        cout << \"бел\";\n        break;\n    case 2:\n    case 3:\n        cout << \"черн\";\n        break;\n    case 4:\n    case 5:\n        cout << \"зелён\";\n        break;\n    case 6:\n    case 7:\n        cout << \"красн\";\n        break;\n    case 8:\n    case 9:\n        cout << \"жёлт\";\n        break;\n    }\n        \n    switch ((a + 1) % 5) {        \n    case 0:\n    case 1:\n    case 2:\n    case 3:\n    case 4:\n    case 5:\n    case 9:\n    case 10:\n    case 11:\n        cout << \"ой \";\n        break;\n    case 6:\n    case 7:\n    case 8:\n        cout << \"ого \";\n        break;\n    }\n        \n    switch ((a + 8) % 12) {        \n    case 0:\n        cout << \"крысы\";\n        break;\n    case 1:\n        cout << \"коровы\";\n        break;\n    case 2:\n        cout << \"тигра\";\n        break;\n    case 3:\n        cout << \"зайца\";\n        break;\n    case 4:\n        cout << \"дракона\";\n        break;\n    case 5:\n        cout << \"змеи\";\n        break;\n    case 6:\n        cout << \"лошади\";\n        break;\n    case 7:\n        cout << \"овцы\";\n        break;\n    case 8:\n        cout << \"обезьяны\";\n        break;\n    case 9:\n        cout << \"курицы\";\n        break;\n    case 10:\n        cout << \"собаки\";\n        break;\n    case 11:\n        cout << \"свиньи\";\n        break;\n    }\n}";
                        break;
                    case 20:
                        richTextBox1.Text = "Даны два целых числа: D (день) и M (месяц), определяющие правильную дату. Вывести знак Зодиака, соответствующий этой дате: «Водолей» (20.1–18.2), «Рыбы» (19.2–20.3), «Овен» (21.3–19.4), «Телец» (20.4–20.5), «Близнецы» (21.5–21.6), «Рак» (22.6–22.7), «Лев» (23.7–22.8), «Дева» (23.8–22.9), «Весы» (23.9–22.10), «Скорпион» (23.10–22.11), «Стрелец» (23.11–21.12), «Козерог» (22.12–19.1).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Rus\");\n    int D, M;\n    cout << \"День: \";\n    cin >> D;\n    cout << \"Месяц: \";\n    cin >> M;\n    switch (M) {        \n    case 1:\n        if (D > 19)\n            cout << \"Водолей\";\n        else\n            cout << \"Козерог\";\n        break;\n    case 2:\n        if (D > 18)\n            cout << \"Рыбы\";\n        else\n            cout << \"Водолей\";\n        break;\n    case 3:\n        if (D > 20)\n            cout << \"Овен\";\n        else\n            cout << \"Рыбы\";\n        break;\n    case 4:\n        if (D > 19)\n            cout << \"Телец\";\n        else\n            cout << \"Овен\";\n        break;\n    case 5:\n        if (D > 20)\n            cout << \"Близнецы\";\n        else\n            cout << \"Телец\";\n        break;\n    case 6:\n        if (D > 21)\n            cout << \"Рак\";\n        else\n            cout << \"Близнецы\";\n        break;\n    case 7:\n        if (D > 22)\n            cout << \"Лев\";\n        else\n            cout << \"Рак\";\n        break;\n    case 8:\n        if (D > 22)\n            cout << \"Дева\";\n        else\n            cout << \"Лев\";\n        break;\n    case 9:\n        if (D > 22)\n            cout << \"Весы\";\n        else\n            cout << \"Дева\";\n        break;\n    case 10:\n        if (D > 22)\n            cout << \"Скорпион\";\n        else\n            cout << \"Весы\";\n        break;\n    case 11:\n        if (D > 22)\n            cout << \"Стрелец\";\n        else\n            cout << \"Скорпион\";\n        break;\n    case 12:\n        if (D > 21)\n            cout << \"Козерог\";\n        else\n            cout << \"Стрелец\";\n        break;\n    }\n}";
                        break;
                    default:
                        richTextBox1.Text = "";
                        richTextBox2.Text = "";
                        break;
                }
            }

            if (comboBox1.SelectedIndex == 5)   // Задачи с For(1-40)
            {
                switch (comboBox2.SelectedIndex + 1)
                {
                    case 1:
                        richTextBox1.Text = "Даны целые числа K и N (N > 0). Вывести N раз число K.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main()\n{    \n    int k, n;\n    cout << \"K: \";\n    cin >> k;\n    \n    cout << \"N: \";\n    cin >> n;\n    \n    int i;\n    for (i = 0; i < n; ++i)\n        cout << k << endl;\n    return 0;\n}";
                        break;
                    case 2:
                        richTextBox1.Text = "Даны два целых числа A и B (A < B). Вывести в порядке возрастания все целые числа, расположенные между A и B (включая сами числа A и B), а также количество N этих чисел.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int A, B, N;\n	cout << \"A: \";\n	cin >> A;\n	cout << \"B: \";\n	cin >> B;\n	N = B - A + 1;\n	for (int i = A; i <= B;i++) {		\n		cout << i << endl;\n	}\n	cout << N;\n}";
                        break;
                    case 3:
                        richTextBox1.Text = "Даны два целых числа A и B (A < B). Вывести в порядке убывания все целые числа, расположенные между A и B (не включая числа A и B), а также количество N этих чисел.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int A, B, n = 1;\n	cout << \"A: \";\n	cin >> A;\n	cout << \"B: \";\n	cin >> B;\n	for (int i = A - 1;i > B;i--) {		\n		cout << n * i << endl;\n	}\n}";
                        break;
                    case 4:
                        richTextBox1.Text = "Дано вещественное число — цена 1 кг конфет. Вывести стоимость 1, 2, …, 10 кг конфет.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    float c;\n    cout << \"Cost:\";\n    cin >> c;\n        \n    for (int i = 1; i <= 10; ++i)\n        cout << i << \" kg = \" << c * i << endl;\n    return 0;\n}";
                        break;
                    case 5:
                        richTextBox1.Text = "Дано вещественное число — цена 1 кг конфет. Вывести стоимость 0.1, 0.2, …, 1 кг конфет.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {\n	float N;\n	cout << \"N: \";\n	cin >> N;\n	for (double i = 0.1;i <= 1;i += 0.1) {		\n		cout << N * i << endl;\n	}\n}";
                        break;
                    case 6:
                        richTextBox1.Text = "Дано вещественное число — цена 1 кг конфет. Вывести стоимость 1.2, 1.4, …, 2 кг конфет.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	float N;\n	cout << \"N: \";\n	cin >> N;\n	for (double i = 1.2;i <= 2;i += 0.2) {		\n		cout << N * i << endl;\n	}\n}";
                        break;
                    case 7:
                        richTextBox1.Text = "Даны два целых числа A и B (A < B). Найти сумму всех целых чисел от A до B включительно.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int a, b;\n    cout << \"A:\";\n    cin >> a;\n    cout << \"B:\";\n    cin >> b;\n    int sum = 0;\n    for (int i = a; i <= b; ++i)\n        sum += i;\n    cout << \"Sum = \" << sum;\n    return 0;\n}";
                        break;
                    case 8:
                        richTextBox1.Text = "Даны два целых числа A и B (A < B). Найти произведение всех целых чисел от A до B включительно.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int a, b, c = 1;\n    cout << \"A:\";\n    cin >> a;\n    cout << \"b:\";\n    cin >> b;\n    for (int i = a; i <= b; i++) {        \n        c *= i;\n    }\n    cout << c;\n}";
                        break;
                    case 9:
                        richTextBox1.Text = "Даны два целых числа A и B (A < B). Найти сумму квадратов всех целых чисел от A до B включительно.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int a, b;\n    cout << \"a: \";\n    cin >> a;\n    cout << \"b: \";\n    cin >> b;\n        \n    int i, rez = 0;\n    for (i = a; i <= b; ++i)\n        rez += i * i;\n    cout << \"Rez: \" << rez;\n}";
                        break;
                    case 10:
                        richTextBox1.Text = "Дано целое число N (> 0). Найти сумму 1 + 1/2 + 1/3 + … + 1/N (вещественное число).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    int N;\n    float plus;\n    cout << \"N: \";\n    cin >> N;\n    if (N > 0) {        \n        for (int i = 1; i <= N; i++) {            \n            plus += 1 / (float)i;\n        }\n        cout << plus;\n    }\n    else {        \n        cout << \"Try again!\";\n    }\n}";
                        break;
                    case 11:
                        richTextBox1.Text = "Дано целое число N (> 0). Найти сумму N2 + (N + 1)2 + (N + 2)2 +…+ (2*N)2 (целое число).";
                        richTextBox2.Text = "#include <iostream>\n#include <math.h>\nusing namespace std;\n\nint main() {    \n    int n;\n    cout << \"n=\";\n    cin >> n;\n        \n    float result = 0;\n    for (int i = 0; i <= n; i++)\n        result += pow(n + i, 2);\n        \n    cout << \"Result=\" << result;\n    return 0;\n}";
                        break;
                    case 12:
                        richTextBox1.Text = "Дано целое число N (> 0). Найти произведение 1.1 *1.2 * 1.3 *… (N сомножителей).";
                        richTextBox2.Text = "#include <iostream>\n\nusing namespace std;\n\nint main() {    \n    int N;\n    double p = 1;\n    double a = 1.1;\n    cout << \"N = \";\n    cin >> N;\n    for (int i = 1; i <= N; ++i) {        \n        p *= a;\n        a += 0.1;\n    }\n    cout << \"Result = \" << p;\n    return 0;\n}";
                        break;
                    case 13:
                        richTextBox1.Text = "Дано целое число N (> 0). Найти значение выражения 1.1 — 1.2 + 1.3 — … (N слагаемых, знаки чередуются). Условный оператор не использовать.";
                        richTextBox2.Text = "#include <iostream>\n#include <math.h>\n\nusing namespace std;\n\nint main()\n{ \n    int n;\n    cout << \"n=\";\n    cin >> n;\n    \n    float rez = 0;\n    for (int i = 1; i <= n; i++)\n        rez += pow(-1, i + 1) * (1.0 + (float)i / 10);\n    cout << \"Result=\" << rez;\n    return 0;\n}";
                        break;
                    case 14:
                        richTextBox1.Text = "Дано целое число N (> 0). Найти квадрат данного числа, используя для его вычисления следующую формулу: N^2 = 1 + 3 + 5 + … + (2*N — 1). После добавления к сумме каждого слагаемого выводить текущее значение суммы (в результате будут выведены квадраты всех целых чисел от 1 до N).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int n;\n    cout << \"N:\";\n    cin >> n;\n        \n    int rez = 0;\n    int i;\n    for (i = 1; i <= (2 * n - 1); i += 2) {        \n        rez += i;\n        cout << rez;\n            \n    }\n}";
                        break;
                    case 15:
                        richTextBox1.Text = "Дано вещественное число A и целое число N (> 0). Найти A в степени N: A^N = A*A*… *A (числа A перемножаются N раз).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int N, b = 1;\n	double A;\n	cout << \"A: \";\n	cin >> A;\n	cout << \"N: \";\n	cin >> N;\n	A = pow(A, N);\n	cout << A;\n}";
                        break;
                    case 16:
                        richTextBox1.Text = "Дано вещественное число A и целое число N (> 0). Используя один цикл, вывести все целые степени числа A от 1 до N.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	float A, b = 1;\n	int N;\n	cout << \"A: \";\n	cin >> A;\n	cout << \"N: \";\n	cin >> N;\n	for (float i = 1;i <= N;i++) {		\n		b = b * A;\n		cout << b << endl;\n	}\n}";
                        break;
                    case 17:
                        richTextBox1.Text = "Дано вещественное число A и целое число N (> 0). Используя один цикл, найти сумму 1 + A + A2 + A3 + … + AN.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	float A;\n	int N, b = 1, c = 1;\n	cout << \"A: \";\n	cin >> A;\n	cout << \"N: \";\n	cin >> N;\n	for (int i = 1;i <= N;i++) {		\n		b *= A;\n		c += b;\n			\n	}\n	cout << c;\n}";
                        break;
                    case 18:
                        richTextBox1.Text = "Дано вещественное число A и целое число N (> 0). Используя один цикл, найти значение выражения 1 — A + A2 — A3 + … + (-1)N*AN. Условный оператор не использовать.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	float A;\n	int N, b = 1, c = 1;\n	cout << \"A: \";\n	cin >> A;\n	cout << \"N: \";\n	cin >> N;\n	for (int i = 1;i <= N;i++) {		\n		b *= -A;\n		c += b;\n			\n	}\n	cout << c;\n}";
                        break;
                    case 19:
                        richTextBox1.Text = "Дано целое число N (> 0). Найти произведение N! = 1*2*…*N (N-факториал). Чтобы избежать целочисленного переполнения, вычислять это произведение с помощью вещественной переменной и вывести его как вещественное число.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int n;\n cout << \"N:\";\n    cin >> n;\n        \n        \n    float rez = 1;\n    int i;\n        \n    for (i = 1; i <= n; ++i)\n        rez *= (float)i;\n        \n    cout << rez;\n}";
                        break;
                    case 20:
                        richTextBox1.Text = "Дано целое число N (> 0). Используя один цикл, найти сумму 1! + 2! + 3! + … + N! (выражение N! — N-факториал — обозначает произведение всех целых чисел от 1 до N: N! = 1*2*…*N ). Чтобы избежать целочисленного переполнения, проводить вычисления с помощью вещественных переменных и вывести результат как вещественное число.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int n;\n    cout << \"N:\";\n    cin >> n;\n        \n        \n    float n1 = 1, rez = 0;\n    int i;\n        \n        \n    for (i = 1; i <= n; ++i) {        \n        n1 *= (float)i;\n        rez += n1;\n    }\n    cout << rez;\n}";
                        break;
                    case 21:
                        richTextBox1.Text = "Дано целое число N (> 0). Используя один цикл, найти сумму 1 + 1/(1!) + 1/(2!) + 1/(3!) +…+ 1/(N!) (выражение N! — N-факториал — обозначает произведение всех целых чисел от 1 до N: N! = 1*2*…*N). Полученное число является приближенным значением константы e = exp(1).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int n;\n    cout << \"N:\";\n    cin >> n;\n    \n    float n1 = 1, rez = 1;\n    int i;\n        \n    for (i = 1; i <= n; ++i) {        \n        n1 *= (float)i;\n        rez += 1 / n1;\n    }\n    cout << rez;\n}";
                        break;
                    case 22:
                        richTextBox1.Text = "Дано вещественное число X и целое число N (> 0). Найти значение выражения 1 + X + X2/(2!) +…+ XN/(N!) (N! = 1*2*…*N). Полученное число является приближенным значением функции exp в точке X.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    float x;\n    cout << \"X:\";\n    cin >> x;\n        \n    int n;\n    cout << \"N:\";\n    cin >> n;\n        \n    float x1 = 1, n1 = 1, rez = 1.0;\n    int i;\n        \n    for (i = 1; i <= n; ++i) {        \n        n1 *= (float)i;\n        x1 *= x;\n        rez += x1 / n1;\n    }\n    cout << rez;\n}";
                        break;
                    case 23:
                        richTextBox1.Text = "Дано вещественное число X и целое число N (> 0). Найти значение выражения X — X3/(3!) + X5/(5!) -…+ (-1)N*X2*N+1/((2*N+1)!) (N! = 1*2*…*N). Полученное число является приближенным значением функции sin в точке X.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    float x;\n    cout << \"X:\";\n    cin >> x;\n        \n    int n;\n    cout << \"N:\";\n    cin >> n;\n        \n    float x1 = x, rez = x;\n    int i;\n    for (i = 1; i < n; ++i) {        \n        x1 *= -1 * x * x;\n        rez += x1;\n    }\n    cout << rez;\n}";
                        break;
                    case 24:
                        richTextBox1.Text = "Дано вещественное число X и целое число N (> 0). Найти значение выражения 1 — X2/(2!) + X4/(4!) -…+ (-1)N*X2*N/((2*N)!) (N! = 1*2*…*N). Полученное число является приближенным значением функции cos в точке X.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	float x, a, b, c;\n	int n, d;\n	a = 1;\n	b = 1;\n	c = 1;\n	d = 0;\n	cout << \"x: \";\n	cin >> x;\n	cout << \"n: \";\n	cin >> n;\n		\n	for (int i = 1;i <= n;i++) {		\n		d = d + 1;\n		b = b * (float)d;\n		a = a * -1 * pow(x, 2);\n		c = c + (a / b);\n	}\n	cout << c;\n}";
                        break;
                    case 25:
                        richTextBox1.Text = "Дано вещественное число X (|X| < 1) и целое число N (> 0). Найти значение выражения X — X2/2 + X3/3 -…+ (-1)N-1*XN/N. Полученное число является приближенным значением функции ln в точке 1 + X.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    float x;\n    cout << \"X:\";\n    cin >> x;\n    int n;\n    cout << \"N:\";\n    cin >> n;\n        \n    float x1 = x, rez = x;\n    int i;\n        \n    for (i = 2; i <= n; ++i) {        \n        x1 *= -1 * x;\n        rez += x1 / i;\n    }\n    cout << rez;\n}";
                        break;
                    case 26:
                        richTextBox1.Text = "Дано вещественное число X (|X| < 1) и целое число N (> 0). Найти значение выражения X — X3/3 + X5/5 -…+ (-1)N*X2*N+1/(2*N+1). Полученное число является приближенным значением функции arctg в точке X.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	float X;\n	int N;\n	cout << \"X: \";\n	cin >> X;\n	cout << \"N: \";\n	cin >> N;\n	if (abs(X) < 1 && N > 0) {		\n		float a = X, b = X;\n		int c = 1;\n		for (int i = 2; i <= N; ++i) {			\n			c += 2;\n			a *= -1 * X * X;\n			b += a / c;\n		}\n		cout << b;\n	}\n	else {		\n		cout << \"Try again!\";\n	}\n}";
                        break;
                    case 27:
                        richTextBox1.Text = "Дано вещественное число X (|X| < 1) и целое число N (> 0). Найти значение выражения X + 1*X3/(2*3) + 1*3*X5/(2*4*5) + … + 1*3*…*(2*N-1)*X2*N+1/(2*4*…*(2*N)*(2*N+1)).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	float X, a = 1;\n	int N;\n	cout << \"X: \";\n	cin >> X;\n	cout << \"N: \";\n	cin >> N;\n	for (int i = 1;i <= N; i++) {		\n		a += (2 * i - 1) * pow(X, 2 * i + 1) / (2 * 4 * (2 * i * 2 * i + 1));\n		cout << a;\n	}\n}";
                        break;
                    case 28:
                        richTextBox1.Text = "Дано вещественное число X (|X| < 1) и целое число N (> 0). Найти значение выражения 1 + X/2 — 1*X2/(2*4) + 1*3*X3/(2*4*6) -… + (-1)N-1*1*3*…*(2*N-3)*XN/(2*4*…*(2*N)). Полученное число является приближенным значением функции √1 + X .";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    float x;\n    cout << \"X:\";\n    cin >> x;\n        \n    int n;\n    cout << \"N:\";\n    cin >> n;\n        \n    float temp1 = 1, temp2 = 1, rez = 1, pow = 1;\n    int i;\n    for (i = 1; i < n; ++i) {        \n        temp1 *= 2 * i - 3;\n        temp2 *= 2 * i;\n        pow *= (-1) * x;\n        rez += temp1 * pow / temp2;\n    }\n    cout << rez;\n}";
                        break;
                    case 29:
                        richTextBox1.Text = "Дано целое число N (> 1) и две вещественные точки на числовой оси: A, B (A < B). Отрезок [A, B] разбит на N равных отрезков. Вывести H — длину каждого отрезка, а также набор точек A, A + H, A + 2*H, A + 3*H,…, B, образующий разбиение отрезка [A, B].";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int n;\n    cout << \"N:\";\n    cin >> n;\n        \n    float a;\n    cout << \"A:\";\n    cin >> a;\n        \n    float b;\n    cout << \"B:\";\n    cin >> b;\n        \n    float h = (b - a) / n;\n    cout << h;\n        \n    int i;\n    for (i = 0; i <= n; ++i) {        \n        cout << a + i * h << \" \";\n    }\n}";
                        break;
                    case 30:
                        richTextBox1.Text = "Дано целое число N (> 14) и две вещественные точки на числовой оси: A, B (A < B). Отрезок [A, B] разбит на N равных отрезков. Вывести H — длину каждого отрезка, а также значения функции F(X) = 1 — sin(X) в точках, разбивающих отрезок [A, B]: F(A), F(A + H), F(A + 2*H),…, F(B).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int n;\n    cout << \"N:\";\n    cin >> n;\n        \n    float a;\n    cout << \"A:\";\n    cin >> a;\n    \n    float b;\n    cout << \"B:\";\n    cin >> b;\n        \n    float h = (b - a) / n;\n    cout << h << \" \";\n        \n    int i;\n    for (i = 0; i <= n; ++i) {        \n        cout << 1 - sin(a + i * h) << \" \";\n    }\n    return 0;\n}";
                        break;
                    case 31:
                        richTextBox1.Text = "Дано целое число N (> 0). Последовательность вещественных чисел A_K определяется следующим образом: A0 = 2, AK = 2 + 1/AK-1, K = 1, 2, … . Вывести элементы A1, A2, …, AN.";
                        richTextBox2.Text = "# include <iostream>\n# include <Windows.h>\n\nusing namespace std;\n\nint main()\n\n{ \n	SetConsoleCP(1251);\n	SetConsoleOutputCP(1251);\n	\n	int N;\n	cout << \"Введите целое число N(>0): \";\n	cin >> N;\n	double A = 2;\n	for (int i = 1; i <= N; ++i) {		\n		A = 2 + 1 / A;\n		cout << A << \" \";\n	}\n	cout << endl;\n	system(\"pause\");\n	return 0;\n}";
                        break;
                    case 32:
                        richTextBox1.Text = "Дано целое число N (> 0). Последовательность вещественных чисел A_K определяется следующим образом: A0 = 1, AK = (AK-1 + 1)/K, K = 1, 2, … . Вывести элементы A1, A2, …, AN.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int n;\n    cout << \"N:\";\n    cin >> n;\n        \n    float ai = 1;\n    cout << ai << \" \";\n    int i;\n    for (i = 1; i <= n; ++i) {        \n        cout << i << \" \" << (ai + 1) / i << \" \";\n        ai = (ai + 1) / i;\n    }\n    return 0;\n}\n";
                        break;
                    case 33:
                        richTextBox1.Text = "Дано целое число N (> 1). Последовательность чисел Фибоначчи FK (целого типа) определяется следующим образом: F1 = 1, F2 = 1, FK = FK-2 + FK-1, K = 3, 4, … . Вывести элементы F1, F2, …, FN.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int N, K, K1, K2;\n	cout << \"N: \";\n	cin >> N;\n	K1 = 1;\n	K2 = 1;\n	for (int i = 0;i <= N;i++) {		\n		K = K1 + K2;\n		K1 = K2;\n		K2 = K;\n		cout << K << \" \";\n	}\n}";
                        break;
                    case 34:
                        richTextBox1.Text = "Дано целое число N (> 1). Последовательность вещественных чисел A_K определяется следующим образом: A1 = 1, A2 = 2, AK = (AK-2 + 2*AK-1)/3, K = 3, 4, … . Вывести элементы A1, A2, …, AN.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int N;\n	float A;\n	float A1, A2, Ak;\n	A1 = 1;\n	A2 = 2;\n	cout << \"N: \";\n	cin >> N;\n	for (int i = 3; i <= N; i++) {		\n		Ak = (A1 + 2 * A2) / 3;\n		cout << A1 << \" \" << A2 << \" \";\n		A1 = A2;\n		A2 = Ak;\n		cout << i << \" \" << Ak << \" \";\n	}\n}";
                        break;
                    case 35:
                        richTextBox1.Text = "Дано целое число N (> 2). Последовательность целых чисел AK определяется следующим образом: A1 = 1, A2 = 2, A3 = 3, AK = AK-1 + AK-2 — 2*AK-3, K = 4, 5, … . Вывести элементы A1, A2, …, AN.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int n;\n    cout << \"N:\";\n    cin >> n;\n    \n    float a1 = 1, a2 = 2, a3 = 3;\n    cout << a1 << \" \";\n    cout << a2 << \" \";\n    cout << a3 << \" \";\n        \n    int i;\n    float ak;\n    for (i = 4; i <= n; ++i) {        \n        ak = a3 + a2 - 2 * a1;\n        cout << i << \" \" << ak << \" \";\n        a1 = a2;\n        a2 = a3;\n        a3 = ak;\n    }\n    return 0;\n}";
                        break;
                    case 36:
                        richTextBox1.Text = "Даны целые положительные числа N и K. Найти сумму 1K + 2K + … + NK. Чтобы избежать целочисленного переполнения, вычислять слагаемые этой суммы с помощью вещественной переменной и выводить результат как вещественное число.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int n, k;\n    cout << \"N:\";\n    cin >> n;\n        \n    cout << \"K:\";\n    cin >> k;\n        \n    int i, i2;\n    float rez = 0, nk;\n    for (i = 1; i <= n; ++i) {        \n        nk = i;\n        for (i2 = 1; i2 <= k; ++i2) nk *= i;\n        rez += nk;\n    }\n    cout << rez;\n    return 0;\n}";
                        break;
                    case 37:
                        richTextBox1.Text = "Дано целое число N (> 0). Найти сумму 11 + 22 + … + NN. Чтобы избежать целочисленного переполнения, вычислять слагаемые этой суммы с помощью вещественной переменной и выводить результат как вещественное число.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int n;\n    cout << \"N:\";\n    cin >> n;\n        \n    int i, i2;\n    float rez = 0, ni;\n    for (i = 1; i <= n; ++i) {        \n        ni = i;\n        for (i2 = 1; i2 <= i; ++i2) ni *= i;\n        rez += ni;\n    }\n    cout << rez;\n            \n    return 0;\n}";
                        break;
                    case 38:
                        richTextBox1.Text = "Дано целое число N (> 0). Найти сумму 1N + 2N-1 + … + N1. Чтобы избежать целочисленного переполнения, вычислять слагаемые этой суммы с помощью вещественной переменной и выводить результат как вещественное число.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int n;\n    cout << \"N:\";\n    cin >> n;\n        \n    int i, i2;\n    float rez = 0, ni;\n    for (i = 1; i <= n; ++i) {        \n        ni = i;\n        for (i2 = 1; i2 <= n - i; ++i2) ni *= i;\n        rez += ni;\n    }\n    cout << rez;\n            \n    return 0;\n}";
                        break;
                    case 39:
                        richTextBox1.Text = "Даны целые положительные числа A и B (A < B). Вывести все целые числа от A до B включительно; при этом каждое число должно выводиться столько раз, каково его значение (например, число 3 выводится 3 раза).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int a, b;\n    cout << \"A:\";\n    cin >> a;\n    cout << \"B:\";\n    cin >> b;\n        \n    int i, i2;\n    for (i = a; i <= b; ++i) {        \n        for (i2 = 1; i2 <= i; ++i2)\n            cout << i << \" \";\n    }\n        \n    return 0;\n}";
                        break;
                    case 40:
                        richTextBox1.Text = "Даны целые числа A и B (A < B). Вывести все целые числа от A до B включительно; при этом число A должно выводиться 1 раз, число A + 1 должно выводиться 2 раза и т. д.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int a, b;\n    cout << \"A:\";\n    cin >> a;\n    cout << \"B:\";\n    cin >> b;\n    \n    int i, i2;\n    for (i = 1; i <= b - a + 1; ++i) {        \n        for (i2 = 1; i2 <= i; ++i2)\n            cout << a + i - 1 << \" \";\n    }\n        \n    return 0;\n}";
                        break;
                    default:
                        richTextBox1.Text = "";
                        richTextBox2.Text = "";
                        break;
                }
            }

            if (comboBox1.SelectedIndex == 6)   // Задачи с While(1-30)
            {
                switch (comboBox2.SelectedIndex + 1)
                {
                    case 1:
                        richTextBox1.Text = "Даны положительные числа A и B (A > B). На отрезке длины A размещено максимально возможное количество отрезков длины B (без наложений). Не используя операции умножения и деления, найти длину незанятой части отрезка A.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Rus\");\n	int a, b;\n	cout << \"A:\";\n	cin >> a;\n	cout << \"B:\";\n	cin >> b;\n		\n	int temp = a;\n	while (temp >= 0) {		\n		temp -= b;\n	}\n	cout << temp + b;\n}";
                        break;
                    case 2:
                        richTextBox1.Text = "Даны положительные числа A и B (A > B). На отрезке длины A размещено максимально возможное количество отрезков длины B (без наложений). Не используя операции умножения и деления, найти количество отрезков B, размещенных на отрезке A.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Rus\");\n	int a, b;\n	cout << \"A:\";\n	cin >> a;\n	cout << \"B:\";\n	cin >> b;\n		\n	int temp = a;\n	int num = 0;\n	while (temp - b >= 0) {		\n		temp -= b;\n		++num;\n	}\n	cout << num;\n}";
                        break;
                    case 3:
                        richTextBox1.Text = "Даны целые положительные числа N и K. Используя только операции сложения и вычитания, найти частное от деления нацело N на K, а также остаток от этого деления.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Rus\");\n	int n, k;\n	cout << \"N:\";\n	cin >> n;\n	cout << \"K:\";\n	cin >> k;\n		\n	int num = 0;\n	while (n >= k) {		\n		n -= k;\n		++num;\n	}\n	cout << num;\n			\n	cout << n;\n			\n	return 0;\n}";
                        break;
                    case 4:
                        richTextBox1.Text = "Дано целое число N (> 0). Если оно является степенью числа 3, то вывести True, если не является — вывести False.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Rus\");\n	int a;\n	cout << \"A:\";\n	cin >> a;\n	while (a > 0) a -= 3;\n	if (a == 0)\n		cout << \"True\";\n	else\n		cout << \"False\";\n		\n	return 0;\n}";
                        break;
                    case 5:
                        richTextBox1.Text = "Дано целое число N (> 0), являющееся некоторой степенью числа 2: N = 2^K. Найти целое число K — показатель этой степени.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Rus\");\n	int n;\n	cout << \"N:\";\n	cin >> n;\n	int k = 0;\n	while (n >= 2) {		\n		++k;\n		n /= 2;\n	}\n	cout << k;\n	return 0;\n}";
                        break;
                    case 6:
                        richTextBox1.Text = "Дано целое число N (> 0). Найти двойной факториал N: N!! = N*(N-2)*(N-4)*… (последний сомножитель равен 2, если N — четное, и 1, если N — нечетное). Чтобы избежать целочисленного переполнения, вычислять это произведение с помощью вещественной переменной и вывести его как вещественное число.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Rus\");\n	int n;\n	cout << \"N:\";\n	cin >> n;\n	float rez = 1;\n	while (n >= 2) {		\n		rez *= n;\n		n -= 2;\n	}\n		\n	cout << rez;\n	return 0;\n}";
                        break;
                    case 7:
                        richTextBox1.Text = "Дано целое число N (> 0). Найти наименьшее целое положительное число K, квадрат которого превосходит N: K2 > N. Функцию извлечения квадратного корня не использовать.";
                        richTextBox2.Text = "#include <iostream>\n#include <Windows.h>\n\nusing namespace std;\n\nint main()\n\n{ \n	SetConsoleCP(1251);\n	SetConsoleOutputCP(1251);\n	\n	int N;\n	int K = 1;\n	cout << \"Введите целое число N (>0): \";\n	cin >> N;\n	while (K * K <= N) {		\n		++K;\n	}\n	cout << \"Наименьшее целое положительное число K, квадрат которого превосходит N: \" << K << endl;\n	system(\"pause\");\n	return 0;\n}";
                        break;
                    case 8:
                        richTextBox1.Text = "Дано целое число N (> 0). Найти наибольшее целое число K, квадрат которого не превосходит N: K2 ≤ N. Функцию извлечения квадратного корня не использовать.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Rus\");\n	int n;\n	cout << \"N:\";\n	cin >> n;\n	int k = 1;\n	while (k * k <= n) ++k;\n	cout << k - 1;\n	return 0;\n}";
                        break;
                    case 9:
                        richTextBox1.Text = "Дано целое число N (> 1). Найти наименьшее целое число K, при котором выполняется неравенство 3K > N.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Rus\");\n	int n;\n	cout << \"N:\";\n	cin >> n;\n	int k = 1, temp = 3;\n	while (temp <= n) {		\n		temp *= 3;\n		++k;\n	}\n	cout << k;\n	return 0;\n}";
                        break;
                    case 10:
                        richTextBox1.Text = "Дано целое число N (> 1). Найти наибольшее целое число K, при котором выполняется неравенство 3K < N.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\n\nusing namespace std;\n\nint main()\n{ \n    int N;\n    cout << \"N:\";\n    cin >> N;\n    \n    int i = 0;\n    while (pow(3, i) < N)\n    { \n        k++;\n    }\n    cout << k - 1;\n}";
                        break;
                    case 11:
                        richTextBox1.Text = "Дано целое число N (> 1). Вывести наименьшее из целых чисел K, для которых сумма 1 + 2 + … + K будет больше или равна N, и саму эту сумму.";
                        richTextBox2.Text = "# include <iostream>\n# include <windows.h>\n# include <cmath>\n\nusing namespace std;\n\nint main()\n\n{ \n	SetConsoleCP(1251);\n	SetConsoleOutputCP(1251);\n\n	int N;\n	int K = 0;\n	int S = 0;\n	cout << \"Введите целое число N (>1): \";\n	cin >> N;\n	while (S <= N) {		\n		++K;\n		S += K;\n	}\n	cout << \"Наименьшее из целых чисел K, для которых сумма 1 + 2 + ... + K будет больше или равна N:   \" << \"K= \" << K << endl;\n	system(\"pause\");\n	return 0;\n}";
                        break;
                    case 12:
                        richTextBox1.Text = "Дано целое число N (> 1). Вывести наибольшее из целых чисел K, для которых сумма 1 + 2 + … + K будет меньше или равна N, и саму эту сумму.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int n;\n    cout << \"N:\";\n    cin >> n;\n    int k = 0, temp = 0;\n    while (!(temp + k + 1 > n)) {        \n        ++k;\n        temp += k;\n    }\n    cout << k << endl << temp;\n    return 0;\n}";
                        break;
                    case 13:
                        richTextBox1.Text = "Дано число A (> 1). Вывести наименьшее из целых чисел K, для которых сумма 1 + 1/2 + …+ 1/K будет больше A, и саму эту сумму.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    float a;\n    cout << \"A:\";\n    cin >> a;\n    int k = 0;\n    float temp = 0;\n    while (temp <= a) {        \n        ++k;\n        temp += 1 / (float)k;\n    }\n    cout << k << endl << temp;\n    return 0;\n}";
                        break;
                    case 14:
                        richTextBox1.Text = "Дано число A (> 1). Вывести наибольшее из целых чисел K, для которых сумма 1 + 1/2 + … + 1/K будет меньше A, и саму эту сумму.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    float a;\n    cout << \"A:\";\n    cin >> a;\n    int k = 0;\n    float temp = 0;\n    while (temp <= a) {        \n        ++k;\n        temp += 1 / (float)k;\n    }\n    cout << \"K:\" << k - 1 << endl << \"Nsum:\" << temp - 1 / (float)k;\n    return 0;\n}";
                        break;
                    case 15:
                        richTextBox1.Text = "Начальный вклад в банке равен 1000 руб. Через каждый месяц размер вклада увеличивается на P процентов от имеющейся суммы (P — вещественное число, 0 < P < 25). По данному P определить, через сколько месяцев размер вклада превысит 1100 руб., и вывести найденное количество месяцев K (целое число) и итоговый размер вклада S (вещественное число).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    float p;\n    cout << \"P:\";\n    cin >> p;\n    int k = 1;\n    float s = 1000;\n    while (s <= 1100) {        \n        ++k;\n        s += s * p / 100;\n    }\n    cout << \"k:\" << k << endl << \"nS:\" << s;\n    return 0;\n}";
                        break;
                    case 16:
                        richTextBox1.Text = "Спортсмен-лыжник начал тренировки, пробежав в первый день 10 км. Каждый следующий день он увеличивал длину пробега на P процентов от пробега предыдущего дня (P — вещественное, 0 < P < 50). По данному P определить, после какого дня суммарный пробег лыжника за все дни превысит 200 км, и вывести найденное количество дней K (целое) и суммарный пробег S (вещественное число).";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\n\nusing namespace std;\n\nint main()\n{ \n    float p, d = 1, S = 10, s = S;\n    cout << \"P:\";\n    cin >> p;\n    \n    while (s < 200)\n    { \n        S += S * p;\n        s += S;\n        d++;\n    }\n    cout << d;\n}";
                        break;
                    case 17:
                        richTextBox1.Text = "Дано целое число N (> 0). Используя операции деления нацело и взятия остатка от деления, вывести все его цифры, начиная с самой правой (разряда единиц).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int n;\n    cout << \"N:\";\n    cin >> n;\n    while (n > 0) {        \n        cout << n % 10;\n        n /= 10;\n    }\n    return 0;\n}\n";
                        break;
                    case 18:
                        richTextBox1.Text = "Дано целое число N (> 0). Используя операции деления нацело и взятия остатка от деления, найти количество и сумму его цифр.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int n;\n    cout << \"N:\";\n    cin >> n;\n    int sum = 0, num = 0;\n    while (n > 0) {        \n        ++num;\n        sum += n % 10;\n        n /= 10;\n    }\n    cout << \"Num:\" << num << endl << \"Sum:\" << sum;\n    return 0;\n}";
                        break;
                    case 19:
                        richTextBox1.Text = "Дано целое число N (> 0). Используя операции деления нацело и взятия остатка от деления, найти число, полученное при прочтении числа N справа налево.";
                        richTextBox2.Text = "# include <iostream>\n# include <windows.h>\n# include <cmath>\n# include <iomanip>\n# include <fstream>\n\nusing namespace std;\n\nint main()\n{ \n	SetConsoleCP(1251);\n	SetConsoleOutputCP(1251);\n	\n	int N;\n	int R = 0;\n	cout << \"Введите  целое число N (>0): \";\n	cin >> N;\n	while (N > 0) {		\n		int M = N % 10;\n		R = R * 10 + M;\n		N /= 10;\n	}\n	cout << \"Число полученное при прочтении числа N справа налево: \" << R << endl;\n			\n	system(\"pause\");\n	return 0;\n}";
                        break;
                    case 20:
                        richTextBox1.Text = "Дано целое число N (> 0). С помощью операций деления нацело и взятия остатка от деления определить, имеется ли в записи числа N цифра «2». Если имеется, то вывести True, если нет — вывести False.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int n;\n    cout << \"N:\";\n    cin >> n;\n    while ((n > 0) & ((n % 10) != 2)) {        \n        n /= 10;\n    }\n    if ((n > 0) && (n % 10) == 2)\n        cout << \"True\";\n    else\n        cout << \"False\";\n    return 0;\n}";
                        break;
                    case 21:
                        richTextBox1.Text = "Дано целое число N (> 0). С помощью операций деления нацело и взятия остатка от деления определить, имеются ли в записи числа N нечетные цифры. Если имеются, то вывести True, если нет — вывести False.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\n\nusing namespace std;\n\nint main()\n{ \n    int N;\n    cout << \"N:\";\n    cin >> N;\n    \n    while ((N > 0) & ((N % 10) % 2 == 0))\n    { \n        N /= 10;\n    }\n    if ((N % 10) % 2 != 0) cout << \"True\";\n    else cout << \"False\";\n}";
                        break;
                    case 22:
                        richTextBox1.Text = "Дано целое число N (> 1). Если оно является простым, то есть не имеет положительных делителей, кроме 1 и самого себя, то вывести True, иначе вывести False.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int n;\n    cout << \"N:\";\n    cin >> n;\n    int k = 2;\n    while ((k < n - 1) & ((n % k) != 0)) {        \n        ++k;\n    }\n    if ((n % k) != 0)\n        cout << \"True\";\n    else\n        cout << \"False\";\n    return 0;\n}";
                        break;
                    case 23:
                        richTextBox1.Text = "Даны целые положительные числа A и B. Найти их наибольший общий делитель (НОД), используя алгоритм Евклида: НОД(A,B) = НОД(B, A mod B), если B ≠ 0; НОД(A, 0) = A.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int A, B;\n	cout << \"A: \";\n	cin >> A;\n	cout << \"B: \";\n	cin >> B;\n		\n	while ((A != 0) & (A != 0)) {		\n		if (A > B) A = A % B;\n		else B = B % A;\n	}\n	cout << A + B;\n}";
                        break;
                    case 24:
                        richTextBox1.Text = "Дано целое число N (> 1). Последовательность чисел Фибоначчи FK определяется следующим образом: F1 = 1, F2 = 1,FK = FK-2 + FK-1, K = 3, 4, … . Проверить, является ли число N числом Фибоначчи. Если является, то вывести True, если нет — вывести False.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    int N, F1, F2, F;\n    cin >> N;\n    F = 0;\n    F1 = 1;\n    F2 = 1;\n    while (F < N) {        \n        F = F2 + F1;\n        F2 = F1;\n        F1 = F;\n    }\n    if (F == N)\n        cout << \"True\";\n    else\n        cout << \"False\";\n}";
                        break;
                    case 25:
                        richTextBox1.Text = "Дано целое число N (> 1). Найти первое число Фибоначчи, большее N. (определение чисел Фибоначчи дано в задании While24).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int n;\n    cout << \"N:\";\n    cin >> n;\n    \n    int f1 = 1, f2 = 1, f = 0;\n        \n    while (f < n + 1) {        \n        f = f2 + f1;\n        f2 = f1;\n        f1 = f;\n    }\n    cout << f;\n    return 0;\n}";
                        break;
                    case 26:
                        richTextBox1.Text = "Дано целое число N (> 1), являющееся числом Фибоначчи: N = F_K (определение чисел Фибоначчи дано в задании While24). Найти целые числа FK-1 и FK+1 — предыдущее и последующее числа Фибоначчи.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int n;\n    cout << \"N:\";\n    cin >> n;\n        \n    int f1 = 1, f2 = 1, f = 0;\n        \n    while (f < n) {        \n        f = f2 + f1;\n        f2 = f1;\n        f1 = f;\n    }\n    cout << \"F_k - 1 =\" << f2 << endl << \"F_k+1=\" << f1 + f2;\n    return 0;\n}";
                        break;
                    case 27:
                        richTextBox1.Text = "Дано целое число N (> 1), являющееся числом Фибоначчи: N = FK (определение чисел Фибоначчи дано в задании While24). Найти целое число K — порядковый номер числа Фибоначчи N.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int n;\n    cout << \"N:\";\n    cin >> n;\n    int f1 = 1, f2 = 1, f = 0, k = 2;\n    while (f < n) {        \n        ++k;\n        f = f2 + f1;\n        f2 = f1;\n        f1 = f;\n    }\n    cout << \"k:\" << k;\n    return 0;\n}";
                        break;
                    case 28:
                        richTextBox1.Text = "Дано вещественное число ε (> 0). Последовательность вещественных чисел AK определяется следующим образом: A1 = 2 , AK = 2 + 1/AK-1, K = 2, 3, … . Найти первый из номеров K, для которых выполняется условие |AK — AK-1| < ε, и вывести этот номер, а также числа AK-1 и AK.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\n\nusing namespace std;\n\nint main()\n{ \n    float e;\n    cout << \"e:\";\n    cin >> e;\n    float ak1 = 0, ak = 2;\n    int k = 1;\n    while (abs(ak - ak1) >= e) {        \n        ++k;\n        ak1 = ak;\n        ak = 2 + 1 / ak1;\n    }\n    cout << \"K= \" << k << \", A(k-1)=\" << ak1 << \", A(k)=\" << ak;\n    return 0;\n}";
                        break;
                    case 29:
                        richTextBox1.Text = "Дано вещественное число ε (> 0). Последовательность вещественных чисел AK определяется следующим образом: A1= 1 , A2 = 2 , AK = (AK-2 + 2*AK-1)/3 , K = 3, 4, … . Найти первый из номеров K, для которых выполняется условие |AK — AK-1| < ε, и вывести этот номер, а также числа AK-1 и AK.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    float e;\n    cout << \"e:\";\n    cin >> e;\n    float ak1 = 1, ak = 2, ak2;\n    int k = 2;\n    while (fabs(ak - ak1) >= e) {        \n        ak2 = ak1;\n        ak1 = ak;\n        ak = (ak2 + 2 * ak1) / 3;\n        ++k;\n    }\n    cout << \"k:\" << k << endl << \"A(k-1):\" << ak1 << endl << \"Ak:\" << ak;\n            \n    return 0;\n}";
                        break;
                    case 30:
                        richTextBox1.Text = "Даны положительные числа A, B, C. На прямоугольнике размера A × B размещено максимально возможное количество квадратов со стороной C (без наложений). Найти количество квадратов, размещенных на прямоугольнике. Операции умножения и деления не использовать.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    float a, b, c;\n    cout << \"A:\";\n    cin >> a;\n    cout << \"B:\";\n    cin >> b;\n    cout << \"C:\";\n    cin >> c;\n        \n    int k = 0;\n    float temp;\n    while ((a - c) >= 0) {        \n        a -= c;\n        temp = b;\n        while (temp - c >= 0) {            \n            temp -= c;\n            ++k;\n        }\n    }\n    cout << \"K:\" << k;\n    return 0;\n}";
                        break;
                    default:
                        richTextBox1.Text = "";
                        richTextBox2.Text = "";
                        break;
                }
            }
            /*
            if (comboBox1.SelectedIndex == )   // Задачи с Series(1-40)
            {
                switch (comboBox2.SelectedIndex + 1)
                {
                    case 1:
                        richTextBox1.Text = "Даны десять вещественных чисел. Найти их сумму.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    float  rez = 0, r;\n    int i;\n    for (i = 1; i <= 10; ++i) {        \n        cout << \"i\" << i << \"-\";\n        cin >> r;\n        rez += r;\n    }\n    cout << rez;\n    return 0;\n}";
                        break;
                    case 2:
                        richTextBox1.Text = "Даны десять вещественных чисел. Найти их произведение.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    float  rez = 1, r;\n    int i;\n    for (i = 1; i <= 10; ++i) {        \n        cout << \"i\" << i << \"-\";\n        cin >> r;\n        rez *= r;\n    }\n    cout << rez;\n    return 0;\n}";
                        break;
                    case 3:
                        richTextBox1.Text = "Даны десять вещественных чисел. Найти их среднее арифметическое.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    float  rez = 1, r;\n    int i;\n    for (i = 1; i <= 10; ++i) {        \n        cout << \"i\" << i << \"-\";\n        cin >> r;\n        rez += r;\n            \n    }\n    rez = rez / 10;\n    cout << rez;\n    return 0;\n}";
                        break;
                    case 4:
                        richTextBox1.Text = "Дано целое число N и набор из N вещественных чисел. Вывести сумму и произведение чисел из данного набора.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    float  sum = 0, pro = 1, r;\n    int i;\n    for (i = 1; i <= 10; ++i) {        \n        cout << \"i\" << i << \"-\";\n        cin >> r;\n        sum += r;\n        pro *= r;\n    }\n    cout << \"Сумма\" << sum << endl << \"Произведение\" << pro;\n    return 0;\n}";
                        break;
                    case 5:
                        richTextBox1.Text = "Дано целое число N и набор из N положительных вещественных чисел. Вывести в том же порядке целые части всех чисел из данного набора (как вещественные числа с нулевой дробной частью), а также сумму всех целых частей.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    float  r;\n    int i, n, sum = 0;\n    cout << \"N:\";\n    cin >> n;\n    for (i = 1; i <= n; ++i) {        \n        cout << \"i\" << i << \"-\";\n        cin >> r;\n        cout << (float)(int)r;\n        sum += (int)r;\n    }\n    cout << \"Сумма\" << sum;\n    return 0;\n}";
                        break;
                    case 6:
                        richTextBox1.Text = "Дано целое число N и набор из N положительных вещественных чисел. Вывести в том же порядке дробные части всех чисел из данного набора (как вещественные числа с нулевой целой частью), а также произведение всех дробных частей.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    float  r, pro = 1;\n    int i, n;\n    cout << \"N:\";\n    cin >> n;\n    for (i = 1; i <= n; ++i) {        \n        cout << \"i\" << i << \"-\";\n        cin >> r;\n        cout << r - (float)((int)r) << endl;\n        pro *= r - (float)((int)r);\n    }\n    cout << \"произведение\" << pro;\n    return 0;\n}";
                        break;
                    case 7:
                        richTextBox1.Text = "Дано целое число N и набор из N вещественных чисел. Вывести в том же порядке округленные значения всех чисел из данного набора (как целые числа), а также сумму всех округленных значений.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    float  r;\n    int i, n, sum = 0;\n    cout << \"N:\";\n    cin >> n;\n    for (i = 1; i <= n; ++i) {        \n        cout << \"i\" << i << \"-\";\n        cin >> r;\n        cout << (int)(r + (r >= 0 ? 0.5 : -0.5));\n        sum += (int)(r + (r >= 0 ? 0.5 : -0.5));\n    }\n    cout << \"Сумма\" << sum;\n    return 0;\n}";
                        break;
                    case 8:
                        richTextBox1.Text = "Дано целое число N и набор из N целых чисел. Вывести в том же порядке все четные числа из данного набора и количество K таких чисел.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int i, n, k, num = 0;\n    cout << \"N:\";\n    cin >> n;\n    for (i = 1; i <= n; ++i) {        \n        cout << \"i\" << i << \" - \";\n        cin >> k;\n        if (k % 2 == 0) {            \n            cout << k << endl;\n            ++num;\n        }\n    }\n    cout << \"Количество\" << num;\n    return 0;\n}";
                        break;
                    case 9:
                        richTextBox1.Text = "Дано целое число N и набор из N целых чисел. Вывести в том же порядке номера всех нечетных чисел из данного набора и количество K таких чисел.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int i, n, k = 0, r;\n    cout << \"N:\";\n    cin >> n;\n    for (i = 1; i <= n; ++i) {        \n        cout << i << \" - \";\n        cin >> r;\n        if (r % 2 != 0) {            \n            cout << r << endl;\n            ++k;\n        }\n    }\n    cout << endl << k;\n    return 0;\n}";
                        break;
                    case 10:
                        richTextBox1.Text = "Дано целое число N и набор из N целых чисел. Если в наборе имеются положительные числа, то вывести True; в противном случае вывести False.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int i, n, r, b = 0;\n    cout << \"N:\";\n    cin >> n;\n    for (i = 1; i <= n; ++i) {        \n        cout << i;\n        cin >> r;\n        if (r > 0) b = 1;\n    }\n    if (b == 1)\n        cout << \"true\";\n    else\n        cout << \"False\";\n        \n    return 0;\n}";
                        break;
                    case 11:
                        richTextBox1.Text = "Даны целые числа K, N и набор из N целых чисел. Если в наборе имеются числа, меньшие K, то вывести True; в противном случае вывести False.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int k, n, i, r, b = 0;\n    cout << \"N:\";\n    cin >> n;\n    cout << \"K:\";\n    cin >> k;\n    for (i = 1; i <= n; ++i) {        \n        cout << i << \" - \";\n        cin >> r;\n            \n        if (r < k)b = 1;\n    }\n    if (b == 1)\n        cout << \"true\";\n    else\n        cout << \"False\";\n        \n    return 0;\n}";
                        break;
                    case 12:
                        richTextBox1.Text = "Дан набор ненулевых целых чисел; признак его завершения — число 0. Вывести количество чисел в наборе.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int i = 0, r = 1;\n    while (r != 0) {        \n        ++i;\n        cout << i << \"-\";\n        cin >> r;\n    }\n    cout << i - 1;\n    return 0;\n}";
                        break;
                    case 13:
                        richTextBox1.Text = "Дан набор ненулевых целых чисел; признак его завершения — число 0. Вывести сумму всех положительных четных чисел из данного набора. Если требуемые числа в наборе отсутствуют, то вывести 0.";
                        richTextBox2.Text = "# include <iostream>\n# include <windows.h>\n# include <cmath>\n# include <iomanip>\n# include <fstream>\n\nusing namespace std;\n\nint main()\n\n{ \n	SetConsoleCP(1251);\n	SetConsoleOutputCP(1251);\n	\n	ifstream in(\"Series13.txt\");\n	int a;\n	int S = 0;\n	cout << \"Дан набор ненулевых чисел: \";\n	while (in >> a && a != 0) {		\n		cout << a << \" \";\n		if (a > 0 && a % 2 == 0) {			\n			S += a;\n		}\n	}\n	cout << endl;\n	if (S == 0) cout << 0;\n	else   cout << \"Cумма всех положительных четных чисел из данного набора = \" << S << endl;\n		\n	in.close();\n		\n	system(\"pause\");\n	return 0;\n}";
                        break;
                    case 14:
                        richTextBox1.Text = "Дано целое число K и набор ненулевых целых чисел; признак его завершения — число 0. Вывести количество чисел в наборе, меньших K.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int k, r = 1, num = 0;\n    cout << \"K:\";\n    cin >> k;\n    while (r != 0) {        \n        cout << \"Число-\";\n        cin >> r;\n        if (r < k) ++num;\n    }\n    cout << num - 1;\n            \n    return 0;\n}";
                        break;
                    case 15:
                        richTextBox1.Text = "Дано целое число K и набор ненулевых целых чисел; признак его завершения — число 0. Вывести номер первого числа в наборе, большего K. Если таких чисел нет, то вывести 0.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int k, r = 1, num = 0;\n    cout << \"K:\";\n    cin >> k;\n    while (r != 0) {        \n        cout << \"Число-\";\n        cin >> r;\n        if ((r > k) && (num == 0)) num = r;\n    }\n    cout << num;\n            \n    return 0;\n}";
                        break;
                    case 16:
                        richTextBox1.Text = "Дано целое число K и набор ненулевых целых чисел; признак его завершения — число 0. Вывести номер последнего числа в наборе, большего K. Если таких чисел нет, то вывести 0.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int k, r = 1, num = 0;\n    cout << \"K:\";\n    cin >> k;\n    while (r != 0) {        \n        cout << \"Число-\";\n        cin >> r;\n        if (r > k) num = r;\n    }\n    cout << num;\n            \n    return 0;\n}";
                        break;
                    case 17:
                        richTextBox1.Text = "Дано вещественное число B, целое число N и набор из N вещественных чисел, упорядоченных по возрастанию. Вывести элементы набора вместе с числом B, сохраняя упорядоченность выводимых чисел.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    setlocale(LC_ALL, \"Russian\");\n    int n;\n    float b, r = 1.0;\n    cout << \"N:\";\n    cin >> n;\n    cout << \"B:\";\n    cin >> b;\n    int i, f = 1;\n    for (i = 1; i <= n; ++i) {        \n        cout << \">\";\n        cin >> r;\n            \n        cout << b << \"-\" << r << endl;\n    }\n        \n    return 0;\n}";
                        break;
                    case 18:
                        richTextBox1.Text = "Дано целое число N и набор из N целых чисел, упорядоченный по возрастанию. Данный набор может содержать одинаковые элементы. Вывести в том же порядке все различные элементы данного набора.";
                        richTextBox2.Text = "";
                        break;
                    case 19:
                        richTextBox1.Text = "Дано целое число N (> 1) и набор из N целых чисел. Вывести те элементы в наборе, которые меньше своего левого соседа, и количество K таких элементов.";
                        richTextBox2.Text = "";
                        break;
                    case 20:
                        richTextBox1.Text = "Дано целое число N (> 1) и набор из N целых чисел. Вывести те элементы в наборе, которые меньше своего правого соседа, и количество K таких элементов.";
                        richTextBox2.Text = "#include <iostream>\n\nusing namespace std;\n\nint main()\n{ \n	int quantity, sequence, lastSequence = 0;\n	cin >> quantity;\n	for (int i = 0;i < quantity;++i, lastSequence = sequence)\n	{ \n		cout << \"\";\n		cin >> sequence;\n		if ((lastSequence < sequence) && lastSequence != 0)\n		{ \n			cout << lastSequence << endl;\n		}\n	}\n	return 0;\n}";
                        break;
                    case 21:
                        richTextBox1.Text = "Дано целое число N (> 1) и набор из N вещественных чисел. Проверить, образует ли данный набор возрастающую последовательность. Если образует, то вывести True, если нет — вывести False.";
                        richTextBox2.Text = "";
                        break;
                    case 22:
                        richTextBox1.Text = "Дано целое число N (> 1) и набор из N вещественных чисел. Если данный набор образует убывающую последовательность, то вывести 0; в противном случае вывести номер первого числа, нарушающего закономерность.";
                        richTextBox2.Text = "# include <iostream>\n# include <windows.h>\n# include <cmath>\n# include <iomanip>\n# include <fstream>\n\nusing namespace std;\n\nint main()\n\n{ \n    SetConsoleCP(1251);\n    SetConsoleOutputCP(1251);\n    \n    \n    ifstream in(\"Series22.txt\");\n    double a;\n    double a_;\n    in >> a_;\n    cout << \"Дан набор вещественных чисел: \";\n    cout << a_ << \" \";\n    int i = 1;\n    int n = 0;\n    while (in >> a) {        \n        cout << a << \" \";\n        ++i;\n        if (a >= a_ && n == 0) n = i;\n        a_ = a;\n    }\n    in.close();\n    cout << endl;\n    if (n == 0) cout << \"Последовательность убывающая.\" << endl;\n    else cout << \"Номер первого числа, нарушающего убывающую последовательность: \" << n << endl;\n        \n    system(\"pause\");\n    return 0;\n}";
                        break;
                    case 23:
                        richTextBox1.Text = "Дано целое число N (> 2) и набор из N вещественных чисел. Набор называется пилообразным, если каждый его внутренний элемент либо больше, либо меньше обоих своих соседей (то есть является «зубцом»). Если данный набор является пилообразным, то вывести 0; в противном случае вывести номер первого элемента, не являющегося зубцом.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int n, t, t1, t2;\n    cin >> n;\n    cin >> t1 >> t2;\n    for (int i = 2; i < n; ++i) {        \n        cin >> t;\n        if ((t - t2) * (t1 - t2) <= 0) {            \n            cout << i - 1;\n            return 0;\n        }\n        t1 = t2;\n        t2 = t;\n    }\n    cout << 0;\n    return 0;\n}";
                        break;
                    case 24:
                        richTextBox1.Text = "Дано целое число N и набор из N целых чисел, содержащий по крайней мере два нуля. Вывести сумму чисел из данного набора, расположенных между последними двумя нулями (если последние нули идут подряд, то вывести 0).";
                        richTextBox2.Text = "#include <iostream>\n\nusing namespace std;\n\nint main()\n{	\n	int n, a, sum = 0, tempsum = 0;\n	cin >> n;\n	for (int i = 1;i <= n;i++) {		\n		cin >> a;\n		tempsum += a;\n		if (a == 0) {			\n			sum = tempsum;\n			tempsum = 0;\n		}\n	}\n	cout << \"Sum:\" << sum;\n	return 0;\n}";
                        break;
                    case 25:
                        richTextBox1.Text = "Дано целое число N и набор из N целых чисел, содержащий по крайней мере два нуля. Вывести сумму чисел из данного набора, расположенных между первым и последним нулем (если первый и последний нули идут подряд, то вывести 0).";
                        richTextBox2.Text = "";
                        break;
                    case 26:
                        richTextBox1.Text = "Даны целые числа K, N и набор из N вещественных чисел: A1, A2, …, AN. Вывести K-e степени чисел из данного набора:\n\n(A1)K, (A2)K, …, (AN)K.";
                        richTextBox2.Text = "";
                        break;
                    case 27:
                        richTextBox1.Text = "Дано целое число N и набор из N вещественных чисел: A1, A2, …, AN. Вывести следующие числа:\n\nA1, (A2)2, …, (AN - 1)N - 1, (AN)N.";
                        richTextBox2.Text = "";
                        break;
                    case 28:
                        richTextBox1.Text = "Дано целое число N и набор из N вещественных чисел: A1, A2, …, AN. Вывести следующие числа:\n\n(A1)N, (A2)N - 1, …, (AN - 1)2, AN.";
                        richTextBox2.Text = "";
                        break;
                    case 29:
                        richTextBox1.Text = "Даны целые числа K, N, а также K наборов целых чисел по N элементов в каждом наборе. Вывести общую сумму всех элементов, входящих в данные наборы.";
                        richTextBox2.Text = "";
                        break;
                    case 30:
                        richTextBox1.Text = "Даны целые числа K, N, а также K наборов целых чисел по N элементов в каждом наборе. Для каждого набора вывести сумму его элементов.";
                        richTextBox2.Text = "";
                        break;
                    case 31:
                        richTextBox1.Text = "Даны целые числа K, N, а также K наборов целых чисел по N элемен тов в каждом наборе. Найти количество наборов, содержащих число 2. Если таких наборов нет, то вывести 0.";
                        richTextBox2.Text = "";
                        break;
                    case 32:
                        richTextBox1.Text = "Даны целые числа K, N, а также K наборов целых чисел по N элементов в каждом наборе. Для каждого набора вывести номер его первого элемента, равного 2, или число 0, если в данном наборе нет двоек.";
                        richTextBox2.Text = "";
                        break;
                    case 33:
                        richTextBox1.Text = "Даны целые числа K, N, а также K наборов целых чисел по N элементов в каждом наборе. Для каждого набора вывести номер его последнего элемента, равного 2, или число 0, если в данном наборе нет двоек.";
                        richTextBox2.Text = "";
                        break;
                    case 34:
                        richTextBox1.Text = "Даны целые числа K, N, а также K наборов целых чисел по N элементов в каждом наборе. Для каждого набора выполнить следующее действие: если в наборе содержится число 2, то вывести сумму его элементов; если в наборе нет двоек, то вывести 0.";
                        richTextBox2.Text = "";
                        break;
                    case 35:
                        richTextBox1.Text = "Дано целое число K, а также K наборов ненулевых целых чисел. Признаком завершения каждого набора является число 0. Для каждого набора вывести количество его элементов. Вывести также общее количество элементов во всех наборах.";
                        richTextBox2.Text = "";
                        break;
                    case 36:
                        richTextBox1.Text = "Дано целое число K, а также K наборов ненулевых целых чисел. Каждый набор содержит не менее двух элементов, признаком его завершения является число 0. Найти количество наборов, элементы которых возрастают.";
                        richTextBox2.Text = "";
                        break;
                    case 37:
                        richTextBox1.Text = "Дано целое число K, а также K наборов ненулевых целых чисел. Каждый набор содержит не менее двух элементов, признаком его завершения является число 0. Найти количество наборов, элементы которых возрастают или убывают.";
                        richTextBox2.Text = "";
                        break;
                    case 38:
                        richTextBox1.Text = "Дано целое число K, а также K наборов ненулевых целых чисел. Каждый набор содержит не менее двух элементов, признаком его завершения является число 0. Для каждого набора выполнить следующее действие: если элементы набора возрастают, то вывести 1; если элементы набора убывают, то вывести –1; если элементы набора не возрастают и не убывают, то вывести 0.";
                        richTextBox2.Text = "";
                        break;
                    case 39:
                        richTextBox1.Text = "Дано целое число K, а также K наборов ненулевых целых чисел. Каждый набор содержит не менее трех элементов, признаком его завершения является число 0. Найти количество пилообразных наборов (определение пилообразного набора дано в задании Series23).";
                        richTextBox2.Text = "";
                        break;
                    case 40:
                        richTextBox1.Text = "Дано целое число K, а также K наборов ненулевых целых чисел. Каждый набор содержит не менее трех элементов, признаком его завершения является число 0. Для каждого набора выполнить следующее действие: если набор является пилообразным (см. задание Series23), то вывести количество его элементов; в противном случае вывести номер первого элемента, который не является зубцом.";
                        richTextBox2.Text = "";
                        break;
                    default:
                        richTextBox1.Text = "";
                        richTextBox2.Text = "";
                        break;
                }
            }

            if (comboBox1.SelectedIndex == )   // Задачи с Proc(1-60)
            {
                switch (comboBox2.SelectedIndex + 1)
                {
                    case 1:
                        richTextBox1.Text = "Описать процедуру PowerA3(A, B), вычисляющую третью степень числа A и возвращающую ее в переменной B (A — входной, B — выходной параметр; оба параметра являются вещественными). С помощью этой процедуры найти третьи степени пяти данных чисел.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nfloat alfa(float k);\nint main()\n{ \n	for (int i = 1;i <= 5;i++)\n	{ \n		float a;\n		cin >> a;\n		cout << alfa(a) << endl;\n	}\n	return 0;\n}\nfloat alfa(float k)\n{ \n	float b;\n	b = pow(k, 3);\n	return b;\n}";
                        break;
                    case 2:
                        richTextBox1.Text = "Описать процедуру PowerA234(A, B, C, D), вычисляющую вторую, третью и четвертую степень числа A и возвращающую эти степени соответственно в переменных B, C и D (A — входной, B, C, D — выходные параметры; все параметры являются вещественными). С помощью этой процедуры найти вторую, третью и четвертую степень пяти данных чисел.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nvoid PowerA234(double A, double& B, double& C, double& D) {	\n	B = A * A;\n	C = B * A;\n	D = B * B;\n	return;\n}\nint main() {		\n	srand((int)time(0));\n	double a, b, c, d;\n	for (int i = 0; i < 5; i++) {		\n		a = rand() % 20 - 10;\n		PowerA234(a, b, c, d);\n		cout << \"A = \" << a << \" : \";\n		cout << \"A^2 = \" << b << \" : \";\n		cout << \"A^3 = \" << c << \" : \";\n		cout << \"A^4 = \" << d << endl;\n	}\n		\n	return 0;\n}";
                        break;
                    case 3:
                        richTextBox1.Text = "Описать процедуру Mean(X, Y, AMean, GMean), вычисляющую среднее арифметическое AMean = (X + Y)/2 и среднее геометрическое GMean = √(X * Y) двух положительных чисел X и Y (X и Y — входные, AMean и GMean — выходные параметры вещественного типа). С помощью этой процедуры найти среднее арифметическое и среднее геометрическое для пар (A, B), (A, C), (A, D), если даны A, B, C, D.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nvoid Mean(double X, double Y, \n	double& AMean, double& GMean) {	\n	AMean = (X + Y) / 2.0;\n	GMean = sqrt(X * Y);\n	return;\n}\nint main() {	\n	srand((int)time(0));\n	double a, b, c, d;\n	double AMean, GMean;\n	a = rand() % 20 + 1;\n	b = rand() % 20 + 1;\n	c = rand() % 20 + 1;\n	d = rand() % 20 + 1;\n	cout << \"A = \" << a << \" : \";\n	cout << \"B = \" << b << \" : \";\n	cout << \"C = \" << c << \" : \";\n	cout << \"D = \" << d << endl;\n	Mean(a, b, AMean, GMean);\n	cout << endl << \"(A,B)\" << endl;\n	cout << \"AMean = \" << AMean << \" : \";\n	cout << \"GMean = \" << GMean << endl;\n	Mean(a, c, AMean, GMean);\n	cout << endl << \"(A, C)\" << endl;\n	cout << \"AMean = \" << AMean << \" : \";\n	cout << \"GMean = \" << GMean << endl;\n	Mean(a, d, AMean, GMean);\n	cout << endl << \"(A,D)\" << endl;\n	cout << \"AMean = \" << AMean << \" : \";\n	cout << \"GMean = \" << GMean << endl;\n		\n	return 0;\n}";
                        break;
                    case 4:
                        richTextBox1.Text = "Описать процедуру TrianglePS(a, P, S), вычисляющую по стороне a равностороннего треугольника его периметр P = 3*a и площадь S = a2*√3/4 (a — входной, P и S — выходные параметры; все параметры являются вещественными). С помощью этой процедуры найти периметры и площади трех равносторонних треугольников с данными сторонами.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nvoid TrianglePS(double a, double& P, double& S) {	\n	P = 3.0 * a;\n	S = a * a * sqrt(3) / 4;\n	return;\n}\nint main() {		\n	srand((int)time(0));\n	double a, p, s;\n			\n	for (int i = 0; i < 3; i++) {		\n		a = rand() % 20 + 1;\n		TrianglePS(a, p, s);\n		cout << \"Equilateral triangle #\" << (i + 1) << endl;\n		cout << \"side, a = \" << a << endl;\n		cout << \"perimeter, p = \" << p << endl;\n		cout << \"area, s = \" << s << endl;\n		cout << endl;\n	}\n	return 0;\n}";
                        break;
                    case 5:
                        richTextBox1.Text = "Описать процедуру RectPS(x1, y1, x2, y2, P, S), вычисляющую периметр P и площадь S прямоугольника со сторонами, параллельными осям координат, по координатам (x1, y1), (x2, y2) его противоположных вершин (x1, y1, x2, y2 — входные, P и S — выходные параметры вещественного типа). С помощью этой процедуры найти периметры и площади трех прямоугольников с данными противоположными вершинами.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nvoid func(double x1, double y1, double x2, double y2, double& p, double& s)\n{ \n    int a = abs(x1 - x2);\n    int b = abs(y1 - y2);\n    p = 2 * (a + b);\n    s = a * b;\n}\nint main()\n{ \n    double x1, y1, x2, y2, p, s;\n    for (int i = 0; i < 3; ++i) {        \n        cin >> x1 >> y1 >> x2 >> y2;\n        func(x1, y1, x2, y2, p, s); \n        cout << p << \" \" << s << endl;\n    }\n    return 0;\n}";
                        break;
                    case 6:
                        richTextBox1.Text = "Описать процедуру DigitCountSum(K, C, S), находящую количество C цифр целого положительного числа K, а также их сумму S (K — входной, C и S — выходные параметры целого типа). С помощью этой процедуры найти количество и сумму цифр для каждого из пяти данных целых чисел.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nvoid func(int k, int c, int s)\n{ \n    while (k) {        \n        c++;\n        s += k % 10;\n        k /= 10;\n    }\n    cout << c << \"  \" << s << endl;\n}\nint main()\n{ \n    int k, c, s;\n    for (int i = 0; i < 3; ++i) {        \n        cin >> k; \n        c = 0, s = 0;\n        func(k, c, s); \n    }\n    return 0;\n}";
                        break;
                    case 7:
                        richTextBox1.Text = "Описать процедуру InvertDigits(K), меняющую порядок следования цифр целого положительного числа K на обратный (K — параметр целого типа, являющийся одновременно входным и выходным). С помощью этой процедуры поменять порядок следования цифр на обратный для каждого из пяти данных целых чисел.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nvoid func(int k)\n{    \n    while (k) {        \n        cout << k % 10;\n        k /= 10;\n    }\n    cout << endl;\n}\nint main()\n{ \n    int k, c, s;\n    for (int i = 0; i < 5; ++i) {        \n        cin >> k;\n        func(k);\n    }\n    return 0;\n}";
                        break;
                    case 8:
                        richTextBox1.Text = "Описать процедуру AddRightDigit(D, K), добавляющую к целому положительному числу K справа цифру D (D — входной параметр целого типа, лежащий в диапазоне 0-9, K — параметр целого типа, являющийся одновременно входным и выходным). С помощью этой процедуры последовательно добавить к данному числу K справа данные цифры D1 и D2, выводя результат каждого добавления.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nvoid func(int k, int d, int d1)\n{ \n    cout << k * 10 + d << endl;\n    k = k * 10 + d;\n    cout << k * 10 + d1;\n}\nint main()\n{ \n    int k, d, d1;\n    cin >> k >> d >> d1;\n    func(k, d, d1);\n    return 0;\n}";
                        break;
                    case 9:
                        richTextBox1.Text = "Описать процедуру AddLeftDigit(D, K), добавляющую к целому положительному числу K слева цифру D (D — входной параметр целого типа, лежащий в диапазоне 1-9, K — параметр целого типа, являющийся одновременно входным и выходным). С помощью этой процедуры последовательно добавить к данному числу K слева данные цифры D_1 и D_2, выводя результат каждого добавления.";
                        richTextBox2.Text = "";
                        break;
                    case 10:
                        richTextBox1.Text = "Описать процедуру Swap(X, Y), меняющую содержимое переменных X и Y (X и Y — вещественные параметры, являющиеся одновременно входными и выходными). С ее помощью для данных переменных A, B, C, D последовательно поменять содержимое следующих пар: A и B, C и D, B и C и вывести новые значения A, B, C, D.";
                        richTextBox2.Text = "";
                        break;
                    case 11:
                        richTextBox1.Text = "Описать процедуру Minmax(X, Y), записывающую в переменную X минимальное из значений X и Y, а в переменную Y — максимальное из этих значений (X и Y — вещественные параметры, являющиеся одновременно входными и выходными). Используя четыре вызова этой процедуры, найти минимальное и максимальное из данных чисел A, B, C, D.";
                        richTextBox2.Text = "";
                        break;
                    case 12:
                        richTextBox1.Text = "Описать процедуру SortInc3(A, B, C), меняющую содержимое переменных A, B, C таким образом, чтобы их значения оказались упорядоченными по возрастанию (A, B, C — вещественные параметры, являющиеся одновременно входными и выходными). С помощью этой процедуры упорядочить по возрастанию два данных набора из трех чисел: (A1, B1, C1) и (A2, B2, C2).";
                        richTextBox2.Text = "# include <iostream>\n# include <windows.h>\n# include <cmath>\n# include <iomanip>\n# include <fstream>\n\nusing namespace std;\n\nvoid SortInc3(double& A, double& B, double& C);\n\nint main()\n{ \n    SetConsoleCP(1251);\n    SetConsoleOutputCP(1251);\n    \n    double A1, B1, C1;\n    for (int i = 1; i < 3; ++i) {        \n        cout << \"Введите число A1: \";     cin >> A1;\n        cout << \"Введите число B1: \";     cin >> B1;\n        cout << \"Введите число C1: \";     cin >> C1;\n        SortInc3(A1, B1, C1);\n        cout << A1 << \" \" << B1 << \" \" << C1 << endl;\n    }\n    system(\"pause\");\n    return 0;\n}\n\nvoid SortInc3(double& A, double& B, double& C) {            \n                \n    double	a_new, b_new, c_new;\n    c_new = max(A, max(B, C));\n    a_new = min(A, min(B, C));\n    if ((A <= B) && (B <= C) || (C <= B) && (B <= A)) b_new = B;\n    if ((B <= C) && (C <= A) || (A <= C) && (C <= B)) b_new = C;\n    if ((C <= A) && (A <= B) || (B <= A) && (A <= C)) b_new = A;\n    A = a_new;\n    B = b_new;\n    C = c_new;\n    return;\n}";
                        break;
                    case 13:
                        richTextBox1.Text = "Описать процедуру SortDec3(A, B, C), меняющую содержимое переменных A, B, C таким образом, чтобы их значения оказались упорядоченными по убыванию (A, B, C — вещественные параметры, являющиеся одновременно входными и выходными). С помощью этой процедуры упорядочить по убыванию два данных набора из трех чисел: (A1, B1, C1) и (A2, B2, C2).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nvoid SortDec3(float* mas)\n{ \n	float temp;\n	for (int i = 0; i < 3; i++)\n	{		\n		for (int j = 0; j < 3 - i - 1; j++)\n		{ \n			if (mas[j] < mas[j + 1])\n			{ \n				temp = mas[j];\n				mas[j] = mas[j + 1];\n				mas[j + 1] = temp;\n			}\n		}\n	}\n}\n\nint main()\n{ \n	float* mas = new float[3];\n	for (int i = 0; i > mas[i]; i++)\n		\n	SortDec3(mas);\n	for (int i = 0; i < 3; i++)\n	{		\n		cout << mas[i] << \" \";\n	}\n}";
                        break;
                    case 14:
                        richTextBox1.Text = "Описать процедуру ShiftRight3(A, B, C), выполняющую правый циклический сдвиг: значение A переходит в B, значение B — в C, значение C — в A (A, B, C — вещественные параметры, являющиеся одновременно входными и выходными). С помощью этой процедуры выполнить правый циклический сдвиг для двух данных наборов из трех чисел: (A1, B1, C1) и (A2, B2, C2).";
                        richTextBox2.Text = "";
                        break;
                    case 15:
                        richTextBox1.Text = "Описать процедуру ShiftLeft3(A, B, C), выполняющую левый циклический сдвиг: значение A переходит в C, значение C — в B, значение B — в A (A, B, C — вещественные параметры, являющиеся одновременно входными и выходными). С помощью этой процедуры выполнить левый циклический сдвиг для двух данных наборов из трех чисел: (A1, B1, C1) и (A2, B2, C2).";
                        richTextBox2.Text = "";
                        break;
                    case 16:
                        richTextBox1.Text = "Описать функцию Sign(X) целого типа, возвращающую для вещественного числа X следующие значения: -1, если X < 0; 0, если X = 0; 1, если X > 0. С помощью этой функции найти значение выражения Sign(A) + Sign(B) для данных вещественных чисел A и B.";
                        richTextBox2.Text = "";
                        break;
                    case 17:
                        richTextBox1.Text = "Описать функцию RootsCount(A, B, C) целого типа, определяющую количество корней квадратного уравнения Ax2 + Bx + C = 0 (A, B, C — вещественные параметры, A ≠ 0). С ее помощью найти количество корней для каждого из трех квадратных уравнений с данными коэффициентами. Количество корней определять по значению дискриминанта: D = B2 — 4*A*C.";
                        richTextBox2.Text = "# include <iostream>\n# include <windows.h>\n# include <cmath>\n# include <iomanip>\n# include <fstream>\n\nusing namespace std;\n\nint RootsCount(double A, double B, double C);\n\nint main()\n\n{ \n    SetConsoleCP(1251);\n    SetConsoleOutputCP(1251);\n    double A, B, C;\n    int answer = 0;  \n    for (int i = 1; i < 4; ++i) {        \n        cout << \"Введите число A: \";     cin >> A;\n        cout << \"Введите число B: \";     cin >> B;\n        cout << \"Введите число C: \";     cin >> C;\n        answer = RootsCount(A, B, C);\n        cout << \"Количество корней квадратного уравнения = \" << answer << endl;\n    }\n    system(\"pause\");\n    return 0;\n}\nint RootsCount(double A, double B, double C)\n{ \n    int res;\n    double D;   \n    res = 0;\n    D = B * B - 4 * A * C;\n    if (D < 0) { res = 0; }\n    else if (D == 0) { res = 1; }\n    else if (D > 0) { res = 2; }\n        \n    return res;\n}";
                        break;
                    case 18:
                        richTextBox1.Text = "Описать функцию CircleS(R) вещественного типа, находящую площадь круга радиуса R (R — вещественное). С помощью этой функции найти площади трех кругов с данными радиусами. Площадь круга радиуса R вычисляется по формуле S = πR2. В качестве значения π использовать 3.14.";
                        richTextBox2.Text = "";
                        break;
                    case 19:
                        richTextBox1.Text = "Описать функцию RingS(R1, R2) вещественного типа, находящую площадь кольца, заключенного между двумя окружностями с общим центром и радиусами R1 и R2 (R1 и R2 — вещественные, R_1 > R_2). С ее помощью найти площади трех колец, для которых даны внешние и внутренние радиусы. Воспользоваться формулой площади круга радиуса R: S = πR2. В качестве значения π использовать 3.14.";
                        richTextBox2.Text = "";
                        break;
                    case 20:
                        richTextBox1.Text = "Описать функцию TriangleP(a, h), находящую периметр равнобедренного треугольника по его основанию a и высоте h, проведенной к основанию (a и h — вещественные). С помощью этой функции найти периметры трех треугольников, для которых даны основания и высоты. Для нахождения боковой стороны b треугольника использовать теорему Пифагора:\n\nb2 = (a / 2)2 + h2.";
                        richTextBox2.Text = "";
                        break;
                    case 21:
                        richTextBox1.Text = "Описать функцию SumRange(A, B) целого типа, находящую сумму всех целых чисел от A до B включительно (A и B — целые). Если A > B, то функция возвращает 0. С помощью этой функции найти суммы чисел от A до B и от B до C, если даны числа A, B, C.";
                        richTextBox2.Text = "";
                        break;
                    case 22:
                        richTextBox1.Text = "Описать функцию Calc(A, B, Op) вещественного типа, выполняющую над ненулевыми вещественными числами A и B одну из арифметических операций и возвращающую ее результат. Вид операции определяется целым параметром Op: 1 — вычитание, 2 — умножение, 3 — деление, остальные значения — сложение. С помощью Calc выполнить для данных A и B операции, определяемые данными целыми N1, N2, N3.";
                        richTextBox2.Text = "";
                        break;
                    case 23:
                        richTextBox1.Text = "Описать функцию Quarter(x, y) целого типа, определяющую номер координатной четверти, в которой находится точка с ненулевыми вещественными координатами (x, y). С помощью этой функции найти номера координатных четвертей для трех точек с данными ненулевыми координатами.";
                        richTextBox2.Text = "";
                        break;
                    case 24:
                        richTextBox1.Text = "Описать функцию Even(K) логического типа, возвращающую True, если целый параметр K является четным, и False в противном случае. С ее помощью найти количество четных чисел в наборе из 10 целых чисел.";
                        richTextBox2.Text = "";
                        break;
                    case 25:
                        richTextBox1.Text = "Описать функцию IsSquare(K) логического типа, возвращающую True, если целый параметр K (> 0) является квадратом некоторого целого числа, и False в противном случае. С ее помощью найти количество квадратов в наборе из 10 целых положительных чисел.";
                        richTextBox2.Text = "#include <iostream>\n#include <windows.h>\n#include <fstream>\n#include <cmath> \n\nusing namespace std;\n\nbool IsSquare(int K);\n\nint main()\n{    \n    SetConsoleCP(1251);\n    SetConsoleOutputCP(1251);\n    \n    int n = 1;\n    int num = 0;\n    int K;\n    int q;\n    ifstream in(\"Proc25.txt\");\n    \n    cout << \"Набор чисел: \";    while (in >> K) {    \n        cout << K << \" \";       if (K > 0) {        \n            q = IsSquare(K);\n            num += q;\n            ++n;\n        }\n    }\n    cout << endl;\n    cout << \"Количество квадратов натуральных чисел в наборе = \" << num << endl;\n    system(\"pause\");\n    return 0;\n}\n\nbool IsSquare(int K)\n{ \n    for (int i = 1; i * i <= K; ++i) {        \n        if (i * i == K) return true;\n    }\n}";
                        break;
                    case 26:
                        richTextBox1.Text = "Описать функцию IsPower5(K) логического типа, возвращающую True, если целый параметр K (> 0) является степенью числа 5, и False в противном случае. С ее помощью найти количество степеней числа 5 в наборе из 10 целых положительных чисел.";
                        richTextBox2.Text = "# include <iostream>\n# include <windows.h>\n# include <cmath>\n# include <iomanip>\n# include <fstream>\n\nusing namespace std;\n\nbool IsPower5(int K);\n\nint main()\n{ \n    SetConsoleCP(1251);\n    SetConsoleOutputCP(1251);\n    \n    int answer = 0;\n    int K;\n    ifstream in(\"Proc26.txt\");\n    \n    cout << \"Набор чисел: \";    while (in >> K) {    \n        cout << K << \" \";       if (K > 0) {        \n            if (IsPower5(K)) ++answer;\n        }\n    }\n    cout << endl;\n    cout << \"Количество степеней числа 5 в наборе = \" << answer << endl;\n    in.close();\n    system(\"pause\");\n    return 0;\n}\n\nbool IsPower5(int K)\n{ \n    int i = 1;\n    while (i < K) {        \n        i *= 5;\n    }\n    return i == K;\n}";
                        break;
                    case 27:
                        richTextBox1.Text = "Описать функцию IsPowerN(K, N) логического типа, возвращающую True, если целый параметр K (> 0) является степенью числа N (> 1), и False в противном случае. Дано число N (> 1) и набор из 10 целых положительных чисел. С помощью функции IsPowerN найти количество степеней числа N в данном наборе.";
                        richTextBox2.Text = "";
                        break;
                    case 28:
                        richTextBox1.Text = "Описать функцию IsPrime(N) логического типа, возвращающую True, если целый параметр N (> 1) является простым числом, и False в противном случае (число, большее 1, называется простым, если оно не имеет положительных делителей, кроме 1 и самого себя). Дан набор из 10 целых чисел, больших 1. С помощью функции IsPrime найти количество простых чисел в данном наборе.";
                        richTextBox2.Text = "";
                        break;
                    case 29:
                        richTextBox1.Text = "Описать функцию DigitCount(K) целого типа, находящую количество цифр целого положительного числа K. Используя эту функцию, найти количество цифр для каждого из пяти данных целых положительных чисел.";
                        richTextBox2.Text = "";
                        break;
                    case 30:
                        richTextBox1.Text = "Описать функцию DigitN(K, N) целого типа, возвращающую N-ю цифру целого положительного числа K (цифры в числе нумеруются справа налево). Если количество цифр в числе K меньше N, то функция возвращает -1. Для каждого из пяти данных целых положительных чисел K1, K2, …, K5 вызвать функцию DigitN с параметром N, изменяющимся от 1 до 5.";
                        richTextBox2.Text = "";
                        break;
                    case 31:
                        richTextBox1.Text = "Описать функцию IsPalindrom(K), возвращающую True, если целый параметр K (> 0) является палиндромом (то есть его запись читается одинаково слева направо и справа налево), и False в противном случае. С ее помощью найти количество палиндромов в наборе из 10 целых положительных чисел. При описании функции можно использовать функции DigitCount и DigitN из заданий Proc29 и Proc30.";
                        richTextBox2.Text = "";
                        break;
                    case 32:
                        richTextBox1.Text = "Описать функцию DegToRad(D) вещественного типа, находящую величину угла в радианах, если дана его величина D в градусах (D — вещественное число, 0 < D < 360). Воспользоваться следующим соотношением: 180° = π радианов. В качестве значения π использовать 3.14. С помощью функции DegToRad перевести из градусов в радианы пять данных углов.";
                        richTextBox2.Text = "";
                        break;
                    case 33:
                        richTextBox1.Text = "Описать функцию RadToDeg(R) вещественного типа, находящую величину угла в градусах, если дана его величина R в радианах (R — вещественное число, 0 < R < 2*π). Воспользоваться следующим соотношением: 180° = π радианов. В качестве значения π использовать 3.14. С помощью функции RadToDeg перевести из радианов в градусы пять данных углов.";
                        richTextBox2.Text = "";
                        break;
                    case 34:
                        richTextBox1.Text = "Описать функцию Fact(N) вещественного типа, вычисляющую значение факториала N! = 1*2*…*N (N > 0 — параметр целого типа; вещественное возвращаемое значение используется для того, чтобы избежать целочисленного переполнения при больших значениях N). С помощью этой функции найти факториалы пяти данных целых чисел.";
                        richTextBox2.Text = "";
                        break;
                    case 35:
                        richTextBox1.Text = "Описать функцию Fact2(N) вещественного типа, вычисляющую двойной факториал:\n\nN!! = 1 * 3 * 5 *…*N, если N — нечетное;\nN!! = 2 * 4 * 6 *…*N, если N — четное\n\n(N > 0 — параметр целого типа; вещественное возвращаемое значение используется для того, чтобы избежать целочисленного переполнения при больших значениях N). С помощью этой функции найти двойные факториалы пяти данных целых чисел.";
                        richTextBox2.Text = "";
                        break;
                    case 36:
                        richTextBox1.Text = "Описать функцию Fib(N) целого типа, вычисляющую N-й элемент последовательности чисел Фибоначчи FK, которая описывается следующими формулами: F1 = 1,F2 = 1, FK = FK-2 + FK-1, K = 3, 4, … . Используя функцию Fib, найти пять чисел Фибоначчи с данными номерами N1, N2, …, N5.";
                        richTextBox2.Text = "";
                        break;
                    case 37:
                        richTextBox1.Text = "Описать функцию Power1(A, B) вещественного типа, находящую величину AB по формуле AB = exp(B*ln(A)) (параметры A и B — вещественные). В случае нулевого или отрицательного параметра A функция возвращает 0. С помощью этой функции найти степени AP, BP, CP, если даны числа P, A, B, C.";
                        richTextBox2.Text = "";
                        break;
                    case 38:
                        richTextBox1.Text = "Описать функцию Power2(A, N) вещественного типа, находящую величину AN (A — вещественный, N — целый параметр) по следующим формулам:\n\nA0 = 1;\nAN = A * A *…*A(N сомножителей), если N > 0;\nAN = 1 / (A * A *…*A) (| N | сомножителей), если N< 0.\n\nС помощью этой функции найти AK, AL, AM, если даны числа A, K, L, M.";
                        richTextBox2.Text = "";
                        break;
                    case 39:
                        richTextBox1.Text = "Используя функции Power1 и Power2 (задания Proc37 и Proc38), описать функцию Power3(A, B) вещественного типа с вещественными параметрами, находящую AB следующим образом: если B имеет нулевую дробную часть, то вызывается функция Power2(A, Round(B)); в противном случае вызывается функция Power1(A, B). С помощью этой функции найти AP, BP, CP, если даны числа P, A, B, C.";
                        richTextBox2.Text = "";
                        break;
                    case 40:
                        richTextBox1.Text = "Описать функцию Exp1(x, E) вещественного типа (параметры x, ε — вещественные, ε > 0), находящую приближенное значение функции exp(x): exp(x) = 1 + x + x^2/(2!) + x^3/(3!) + … + x^n/(n!) + … (n! = 1*2*…*n). В сумме учитывать все слагаемые, большие ε. С помощью Exp1 найти приближенное значение экспоненты для данного x при шести данных ε.";
                        richTextBox2.Text = "";
                        break;
                    case 41:
                        richTextBox1.Text = "Описать функцию Sin1(x, ε) вещественного типа (параметры x, ε — вещественные, ε > 0), находящую приближенное значение функции sin(x):\n\nsin(x) = x — x3 / (3!) + x5 / (5!) — … +(-1)n* x2*n + 1 / ((2 * n + 1)!) + … .\n\nВ сумме учитывать все слагаемые, модуль которых больше ε.С помощью Sin1 найти приближенное значение синуса для данного x при шести данных ε.";
                        richTextBox2.Text = "";
                        break;
                    case 42:
                        richTextBox1.Text = "Описать функцию Cos1(x, ε) вещественного типа (параметры x, ε — вещественные, ε > 0), находящую приближенное значение функции cos(x):\n\ncos(x) = 1 — x2 / (2!) + x4 / (4!) — … +(-1)n* x2*n / ((2 * n)!) + … .\n\nВ сумме учитывать все слагаемые, модуль которых больше ε. С помощью Cos1 найти приближенное значение косинуса для данного x при шести данных ε.";
                        richTextBox2.Text = "";
                        break;
                    case 43:
                        richTextBox1.Text = "Описать функцию Ln1(x, ε) вещественного типа (параметры x, ε— вещественные, |x| < 1, ε > 0), находящую приближенное значение функции\n\nln(1 + x): ln(1 + x) = x — x2 / 2 + x3 / 3 — … +(-1)n* xn+1 / (n + 1) + … .\n\nВ сумме учитывать все слагаемые, модуль которых больше ε. С помощью Ln1 найти приближенное значение ln(1 + x) для данного x при шести данных ε.";
                        richTextBox2.Text = "";
                        break;
                    case 44:
                        richTextBox1.Text = "Описать функцию Arctg1(x, ε) вещественного типа (параметры x, ε — вещественные, |x| < 1, ε > 0), находящую приближенное значение функции arctg(x): arctg(x) = x — x3/3 + x5/5 — … + (-1)n*x2*n+1/(2*n+1) + … . В сумме учитывать все слагаемые, модуль которых больше ε. С помощью Arctg1 найти приближенное значение arctg(x) для данного x при шести данных ε.";
                        richTextBox2.Text = "# include <iostream>\n# include <windows.h>\n# include <cmath>\n# include <iomanip>\n# include <fstream> \n\nusing namespace std;\n\ndouble Arctg1(double x, double e);\nint main()\n\n{ \n    SetConsoleCP(1251);\n    SetConsoleOutputCP(1251);\n    \n    ifstream in(\"Proc44.txt\");\n    double x, e;\n    double answer; \n    cout << \"Введите число x (|x|<1): \";   cin >> x;\n    cout << \"    \" << \"Стандартное значение фунцкции arctg(x): \" << atan(x) << endl;\n    for (int i = 1; i < 7; ++i) {        \n        cout << \"Число e (e>0): \";\n        in >> e;\n        cout << e << \" \";\n        answer = 0;\n        answer = Arctg1(x, e);\n        cout << \"    \" << \"Приближенное значение функции arctg(x): \" << answer << endl;\n    }   system(\"pause\");   return 0;\n}   double Arctg1(double x, double e) {            \n    int i;   double sum, Step;   Step = x;   sum = x;   i = 1;   while (abs(Step * x * x / -(i * 2 + 1)) >= e) {                \n        Step *= -(x * x);\n        sum += Step / (i * 2 + 1);\n        i++;\n    }\n    return sum;\n}";
                        break;
                    case 45:
                        richTextBox1.Text = "Описать функцию Power4(x, a, ε) вещественного типа (параметры x, a, ε — вещественные, |x| < 1; a, ε> 0), находящую приближенное значение функции (1 + x)a: (1 + x)a = 1 + a*x + a*(a-1)*x2/(2!) + … + a*(a-1)*…*(a-n+1)*xn/(n!) + … .";
                        richTextBox2.Text = "";
                        break;
                    case 46:
                        richTextBox1.Text = "Описать функцию NOD2(A, B) целого типа, находящую наибольший общий делитель (НОД) двух целых положительных чисел A и B, используя алгоритм Евклида: НОД(A, B) = НОД(B, A mod B), если B ≠ 0; НОД(A, 0) = A. С помощью этой функции найти наибольшие общие делители пар (A, B), (A, C), (A, D), если даны числа A, B, C, D.";
                        richTextBox2.Text = "";
                        break;
                    case 47:
                        richTextBox1.Text = "Используя функцию NOD2 из задания Proc46, описать процедуру Frac1(a, b, p, q), преобразующую дробь a/b к несократимому виду p/q (все параметры процедуры — целого типа, a и b — входные, p и q — выходные). Знак результирующей дроби p/q приписывается числителю (то есть q > 0). С помощью Frac1 найти несократимые дроби, равные a/b + c/d, a/b + e/f, a/b + g/h (числа a, b, c, d, e, f, g, h даны).";
                        richTextBox2.Text = "";
                        break;
                    case 48:
                        richTextBox1.Text = "Учитывая, что наименьшее общее кратное двух целых положительных чисел A и B равно A*(B/НОД(A, B)), где НОД(A, B) — наибольший общий делитель A и B, и используя функцию NOD2 из задания Proc46, описать функцию NOK2(A, B) целого типа, находящую наименьшее общее кратное чисел A и B. С помощью NOK2 найти наименьшие общие кратные пар (A, B), (A, C), (A, D), если даны числа A, B, C, D.";
                        richTextBox2.Text = "";
                        break;
                    case 49:
                        richTextBox1.Text = "Учитывая соотношение НОД(A, B, C) = НОД(НОД(A, B), C) и используя функцию NOD2 из задания Proc46, описать функцию NOD3(A, B, C) целого типа, находящую наибольший общий делитель трех целых положительных чисел A, B, C. С помощью этой функции найти наибольшие общие делители троек(A, B, C), (A, C, D) и(B, C, D), если даны числа A, B, C, D.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint nod(int a, int b)\n{ \n    while (b) {        \n        int c = a;\n        a = b;\n        b = c % b;\n    }\n    return a;\n}\nvoid func(int a, int b, int c)\n{ \n    a = nod(nod(a, b), c);\n    cout << a << endl;\n}\nint main()\n{ \n    int a, b, c, d;\n    cin >> a >> b >> c >> d;\n    func(a, b, c);\n    func(a, c, d);\n    func(b, c, d);\n    return 0;\n}";
                        break;
                    default:
                        richTextBox1.Text = "";
                        richTextBox2.Text = "";
                        break;
                }
            }

            if (comboBox1.SelectedIndex == 9)   // Задачи с Minmax(1-30)
            {
                switch (comboBox2.SelectedIndex + 1)
                {
                    case 1:
                        richTextBox1.Text = "Дано целое число N и набор из N чисел. Найти минимальный и максимальный из элементов данного набора и вывести их в указанном порядке.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int n, num;\n	int mx, mn;\n	cin >> n;\n	if (n > 1) {		\n		cin >> mn;\n		mx = mn;\n		for (int i = 2; i <= n;i++) {			\n			cin >> num;\n			if (num < mn) { mn = num; }\n			if (num > mx) { mx = num; }\n		}\n		cout << \"Min: \" << mn << \" Max: \" << mx << endl;\n	}\n	system(\"PAUSE\");\n	return 0;\n}";
                        break;
                    case 2:
                        richTextBox1.Text = "Дано целое число N и набор из N прямоугольников, заданных своими сторонами — парами чисел (a, b). Найти минимальную площадь прямоугольника из данного набора.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int a, b, S, N, i, min;\n	char key;\n	cout << \"N: \";\n	cin >> N;\n	cin.get(key);\n	cout << \"1) a = \";\n	cin >> a;\n	cout << \"1) b = \";\n	cin >> b;\n	min = a * b;\n	i = 1;\n	while (i < N) {		\n		i++;\n		cout << \"min= \";\n		cin.get(key);\n		return 0;\n	}\n}";
                        break;
                    case 3:
                        richTextBox1.Text = "Дано целое число N и набор из N прямоугольников, заданных своими сторонами — парами чисел (a, b). Найти максимальный периметр прямоугольника из данного набора.";
                        richTextBox2.Text = "";
                        break;
                    case 4:
                        richTextBox1.Text = "Дано целое число N и набор из N чисел. Найти номер минимального элемента из данного набора.";
                        richTextBox2.Text = "";
                        break;
                    case 5:
                        richTextBox1.Text = "Дано целое число N и набор из N пар чисел (m, v) — данные о массе m и объеме v деталей, изготовленных из различных материалов. Вывести номер детали, изготовленной из материала максимальной плотности, а также величину этой максимальной плотности. Плотность P вычисляется по формуле P = m/v.";
                        richTextBox2.Text = "";
                        break;
                    case 6:
                        richTextBox1.Text = "Дано целое число N и набор из N целых чисел. Найти номера первого минимального и последнего максимального элемента из данного набора и вывести их в указанном порядке.";
                        richTextBox2.Text = "";
                        break;
                    case 7:
                        richTextBox1.Text = "Дано целое число N и набор из N целых чисел. Найти номера первого максимального и последнего минимального элемента из данного набора и вывести их в указанном порядке.";
                        richTextBox2.Text = "";
                        break;
                    case 8:
                        richTextBox1.Text = "Дано целое число N и набор из N целых чисел. Найти номера первого и последнего минимального элемента из данного набора и вывести их в указанном порядке.";
                        richTextBox2.Text = "";
                        break;
                    case 9:
                        richTextBox1.Text = "Дано целое число N и набор из N целых чисел. Найти номера первого и последнего максимального элемента из данного набора и вывести их в указанном порядке.";
                        richTextBox2.Text = "";
                        break;
                    case 10:
                        richTextBox1.Text = "Дано целое число N и набор из N целых чисел. Найти номер первого экстремального (то есть минимального или максимального) элемента из данного набора.";
                        richTextBox2.Text = "";
                        break;
                    case 11:
                        richTextBox1.Text = "Дано целое число N и набор из N целых чисел. Найти номер последнего экстремального (то есть минимального или максимального) элемента из данного набора.";
                        richTextBox2.Text = "";
                        break;
                    case 12:
                        richTextBox1.Text = "Дано целое число N и набор из N чисел. Найти минимальное положительное число из данного набора. Если положительные числа в наборе отсутствуют, то вывести 0.";
                        richTextBox2.Text = "";
                        break;
                    case 13:
                        richTextBox1.Text = "Дано целое число N и набор из N целых чисел. Найти номер первого максимального нечетного числа из данного набора. Если нечетные числа в наборе отсутствуют, то вывести 0.";
                        richTextBox2.Text = "";
                        break;
                    case 14:
                        richTextBox1.Text = "Дано число B (> 0) и набор из десяти чисел. Вывести минимальный из тех элементов набора, которые больше B, а также его номер. Если чисел, больших B, в наборе нет, то дважды вывести 0.";
                        richTextBox2.Text = "";
                        break;
                    case 15:
                        richTextBox1.Text = "Даны числа B, C (0 < B < C) и набор из десяти чисел. Вывести максимальный из элементов набора, содержащихся в интервале (B, C), и его номер. Если требуемые числа в наборе отсутствуют, то дважды вывести 0.";
                        richTextBox2.Text = "";
                        break;
                    case 16:
                        richTextBox1.Text = "Дано целое число N и набор из N целых чисел. Найти количество элементов, расположенных перед первым минимальным элементом.";
                        richTextBox2.Text = "";
                        break;
                    case 17:
                        richTextBox1.Text = "Дано целое число N и набор из N целых чисел. Найти количество элементов, расположенных после последнего максимального элемента.";
                        richTextBox2.Text = "";
                        break;
                    case 18:
                        richTextBox1.Text = "Дано целое число N и набор из N целых чисел. Найти количество элементов, содержащихся между первым и последним максимальным элементом. Если в наборе имеется единственный максимальный элемент, то вывести 0.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int n, maxim = -1, pos, pos1;\n    cin >> n;    vector<int> a(n);\n    for (int i = 0; i < n; ++i) {        \n        cin >> a[i];\n    }\n    for (int i = 0; i < n; ++i) {        \n        if (maxim < a[i]) {            \n            maxim = a[i];\n            pos = i;\n        }\n    }\n    for (int i = n - 1; i >= 1; --i) {        \n        if (a[i] == maxim) {            \n            int s = 0;\n            for (int j = pos + 1; j < i; ++j)\n                s += a[j];\n            cout << s;\n            return 0;\n        }\n    }\n    cout << 0;\n    return 0;\n}";
                        break;
                    case 19:
                        richTextBox1.Text = "Дано целое число N и набор из N целых чисел. Найти количество минимальных элементов из данного набора.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int n, minim = 10000000, k = 0;\n    cin >> n;\n    vector<int> a(n);\n    for (int i = 0; i < n; ++i) {        \n        cin >> a[i];\n    }\n    for (int i = 0; i < n; ++i) {        \n        if (minim > a[i]) {            \n            minim = a[i];\n        }\n    }\n    for (int i = 0; i < n; ++i) {        \n        if (a[i] == minim)\n            ++k;\n    }\n    cout << k;\n    return 0;\n}";
                        break;
                    case 20:
                        richTextBox1.Text = "Дано целое число N и набор из N целых чисел. Найти общее количество экстремальных (то есть минимальных и максимальных) элементов из данного набора.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int n, minim = 10000000, maxim = 0, k = 0;\n    cin >> n;\n    vector<int> a(n);\n    for (int i = 0; i < n; ++i) {        \n        cin >> a[i];\n    }\n    for (int i = 0; i < n; ++i) {        \n        if (minim > a[i]) {            \n            minim = a[i];\n        }\n    }\n    for (int i = 0; i < n; ++i) {        \n        if (maxim < a[i]) {            \n            maxim = a[i];\n        }\n    }\n    for (int i = 0; i < n; ++i) {        \n        if (a[i] == minim)\n            ++k;\n    }\n    for (int i = 0; i < n; ++i) {        \n        if (a[i] == maxim)\n            ++k;\n    }\n    cout << k;\n    return 0;\n}";
                        break;
                    case 21:
                        richTextBox1.Text = "Дано целое число N (> 2) и набор из N чисел — значений некоторой величины, полученных в N опытах. Найти среднее значение этой величины. При вычислении среднего значения не учитывать минимальное и максимальное из имеющихся в наборе значений.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int n, minim = 10000000, maxim = 0, k = 0;\n    cin >> n;\n    vector<int> a(n);\n    for (int i = 0; i < n; ++i) {        \n        cin >> a[i];\n    }\n    for (int i = 0; i < n; ++i) {        \n        if (minim > a[i]) {            \n            minim = a[i];\n        }\n    }\n    for (int i = 0; i < n; ++i) {        \n        if (maxim < a[i]) {            \n            maxim = a[i];\n        }\n    }\n    for (int i = 0; i < n; ++i) {        \n        if (a[i] == minim)\n            ++k;\n    }\n    for (int i = 0; i < n; ++i) {        \n        if (a[i] == maxim)\n            ++k;\n    }\n    int s = 0;\n    for (int i = 0; i < n; ++i) {        \n        if (a[i] != maxim && a[i] != minim)\n            s += a[i];\n    }\n    cout << s / n;\n    return 0;\n}";
                        break;
                    case 22:
                        richTextBox1.Text = "Дано целое число N (> 2) и набор из N чисел. Найти два наименьших элемента из данного набора и вывести эти элементы в порядке возрастания их значений.";
                        richTextBox2.Text = "";
                        break;
                    case 23:
                        richTextBox1.Text = "Дано целое число N (> 3) и набор из N чисел. Найти три наибольших элемента из данного набора и вывести эти элементы в порядке убывания их значений.";
                        richTextBox2.Text = "";
                        break;
                    case 24:
                        richTextBox1.Text = "Дано целое число N (> 1) и набор из N чисел. Найти максимальную сумму двух соседних чисел из данного набора.";
                        richTextBox2.Text = "";
                        break;
                    case 25:
                        richTextBox1.Text = "Дано целое число N (> 1) и набор из N чисел. Найти номера двух соседних чисел из данного набора, произведение которых является минимальным, и вывести вначале меньший, а затем больший номер.";
                        richTextBox2.Text = "";
                        break;
                    case 26:
                        richTextBox1.Text = "Дано целое число N и набор из N целых чисел. Найти максимальное количество четных чисел в наборе, идущих подряд. Если четные числа в наборе отсутствуют, то вывести 0.";
                        richTextBox2.Text = "";
                        break;
                    case 27:
                        richTextBox1.Text = "Дано целое число N и набор из N целых чисел, содержащий только нули и единицы. Найти номер элемента, с которого начинается самая длинная последовательность одинаковых чисел, и количество элементов в этой последовательности. Если таких последовательностей несколько, то вывести номер первой из них.";
                        richTextBox2.Text = "";
                        break;
                    case 28:
                        richTextBox1.Text = "Дано целое число N и набор из N целых чисел, содержащий только нули и единицы. Найти номер элемента, с которого начинается самая длинная последовательность единиц, и количество элементов в этой последовательности. Если таких последовательностей несколько, то вывести номер последней из них. Если единицы в исходном наборе отсутствуют, то дважды вывести 0.";
                        richTextBox2.Text = "";
                        break;
                    case 29:
                        richTextBox1.Text = "Дано целое число N и набор из N целых чисел. Найти максимальное количество подряд идущих минимальных элементов из данного набора.";
                        richTextBox2.Text = "";
                        break;
                    case 30:
                        richTextBox1.Text = "Дано целое число N и набор из N целых чисел. Найти минимальное количество подряд идущих максимальных элементов из данного набора.";
                        richTextBox2.Text = "";
                        break;
                    default:
                        richTextBox1.Text = "";
                        richTextBox2.Text = "";
                        break;
                }
            }
            */
            if (comboBox1.SelectedIndex == 8)   // Задачи с Matrix(1-100)
            {
                switch (comboBox2.SelectedIndex + 1)
                {
                    case 1:
                        richTextBox1.Text = "Даны целые положительные числа M и N. Сформировать целочисленную матрицу размера M × N, у которой все элементы I-й строки имеют значение 10*I (I = 1, …, M).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int n, m;\n    cin >> n >> m;\n    int a[255][255];\n    for (int i = 0; i <= n; ++i) {        \n        for (int j = 0; j <= m; ++j)\n            a[i][j] = 10 * j;\n    }\n    for (int i = 0; i < n; ++i) {        \n        for (int j = 0; j < m; ++j)\n            cout << a[i][j] << \" \";\n        cout << endl;\n    }\n    return 0;\n}";
                        break;
                    case 2:
                        richTextBox1.Text = "Даны целые положительные числа M и N. Сформировать целочисленную матрицу размера M × N, у которой все элементы J-го столбца имеют значение 5*J (J = 1, …, N).";
                        richTextBox2.Text = "#include <iostream>\n#include <windows.h>\n#include <cmath>\n#include <iomanip>\n#include <fstream>\n#include \"IOMatrix.h\"\nusing namespace std;\nint main()\n{ \n	SetConsoleCP(1251);\n	SetConsoleOutputCP(1251);\n	\n	int M, N;\n	cout << \"Введите положительные числа M и N: \";\n	cin >> M >> N;\n	int a[255][255];\n	for (int row = 0; row < M; ++row) {		\n		for (int col = 1; col <= N; ++col) {			\n			a[row][col] = 5 * col;\n		}\n	}\n	for (int row = 0; row < M; ++row) {		\n		for (int col = 1; col <= N; ++col) {			\n			cout << a[row][col] << \" \";\n		}\n		cout << endl;\n	}\n			\n	system(\"pause\");\n	return 0;\n}";
                        break;
                    case 3:
                        richTextBox1.Text = "Даны целые положительные числа M, N и набор из M чисел. Сформировать матрицу размера M × N, у которой в каждом столбце содержатся все числа из исходного набора (в том же порядке).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int m, n;\n    cin >> m >> n;\n    int c[255];\n    for (int i = 0; i < m; ++i) {        \n        cin >> c[i];\n    }\n    int a[255][255];\n    for (int i = 0; i < n; ++i) {        \n        for (int j = 0; j < m; ++j)\n            a[j][i] = c[j];\n    }\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n; ++j)\n            cout << a[i][j] << \" \";\n        cout << endl;\n    }\n    return 0;\n}";
                        break;
                    case 4:
                        richTextBox1.Text = "Даны целые положительные числа M, N и набор из N чисел. Сформировать матрицу размера M × N, у которой в каждой строке содержатся все числа из исходного набора (в том же порядке).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int m, n;\n    cin >> m >> n;\n    int c[255];\n    for (int i = 0; i < n; ++i) {        \n        cin >> c[i];\n    }\n    int a[255][255];\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n; ++j)\n            a[i][j] = c[j];\n    }\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n; ++j)\n            cout << a[i][j] << \" \";\n        cout << endl;\n    }\n    return 0;\n}";
                        break;
                    case 5:
                        richTextBox1.Text = "Даны целые положительные числа M, N, число D и набор из M чисел.Сформировать матрицу размера M × N, у которой первый столбец совпадает с исходным набором чисел, а элементы каждого следующего столбца равны сумме соответствующего элемента предыдущего столбца и числа D (в результате каждая строка матрицы будет содержать элементы арифметической прогрессии).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int m, n, d;\n    cin >> m >> n >> d;\n    int a[255][255];\n    for (int i = 0; i < m; ++i) {        \n        cin >> a[i][0];\n    }\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 1; j < n; ++j)\n            a[i][j] = a[i][j - 1] + d;\n    }\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n; ++j)\n            cout << a[i][j] << \" \";\n        cout << endl;\n    }\n    return 0;\n}";
                        break;
                    case 6:
                        richTextBox1.Text = "Даны целые положительные числа M, N, число Q и набор из N чисел. Сформировать матрицу размера M × N, у которой первая строка совпадает с исходным набором чисел, а элементы каждой следующей строки равны соответствующему элементу предыдущей строки, умноженному на Q (в результате каждый столбец матрицы будет содержать элементы геометрической прогрессии).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int m, n, q;\n    cin >> m >> n >> q;\n    int a[255][255];\n    for (int i = 0; i < n; ++i) {        \n        cin >> a[0][i];\n    }\n    for (int i = 1; i < m; ++i) {        \n        for (int j = 0; j < n; ++j) {            \n            a[i][j] = a[i - 1][j] * q;\n        }\n    }\n    for (int i = 0; i < m; ++i) {\n        for (int j = 0; j < n; ++j)\n            cout << a[i][j] << \" \";\n        cout << endl;\n    }\n    return 0;\n}";
                        break;
                    case 7:
                        richTextBox1.Text = "Дана матрица размера M × N и целое число K (1 ≤ K ≤ M). Вывести элементы K-й строки данной матрицы.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int m, n, k;\n    cin >> m >> n >> k;\n    int a[255][255];\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n; ++j)\n            cin >> a[i][j];\n    }\n    for (int i = 0; i < n; ++i)\n        cout << a[k - 1][i] << \" \";\n    return 0;\n}";
                        break;
                    case 8:
                        richTextBox1.Text = "Дана матрица размера M × N и целое число K (1 ≤ K ≤ N). Вывести элементы K-го столбца данной матрицы.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int m, n, k;\n    cin >> m >> n >> k;\n    int a[255][255];\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n; ++j)\n            cin >> a[i][j];\n    }\n    for (int i = 0; i < m; ++i)\n        cout << a[i][k - 1] << \" \";\n    return 0;\n}";
                        break;
                    case 9:
                        richTextBox1.Text = "Дана матрица размера M × N. Вывести ее элементы, расположенные в строках с четными номерами (2, 4, …). Вывод элементов производить по строкам, условный оператор не использовать.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int m, n;\n    cin >> m >> n;\n    int a[255][255];\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n; ++j)\n            cin >> a[i][j];\n    }\n    for (int i = 1; i < m; i += 2) {        \n        for (int j = 0; j < n; j++)\n            cout << a[i][j] << ' ';\n        cout << endl;\n    }\n    return 0;\n}";
                        break;
                    case 10:
                        richTextBox1.Text = "Дана матрица размера M × N. Вывести ее элементы, расположенные в столбцах с нечетными номерами (1, 3, …). Вывод элементов производить по столбцам, условный оператор не использовать.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int m, n;\n    cin >> m >> n;\n    int a[255][255];\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n; ++j)\n            cin >> a[i][j];\n    }\n    for (int i = 0; i < n; i += 2) {        \n        for (int j = 0; j < m; j++)\n            cout << a[j][i] << ' ';\n        cout << endl;\n    }\n    return 0;\n}";
                        break;
                    case 11:
                        richTextBox1.Text = "Дана матрица размера M × N. Вывести ее элементы в следующем порядке: первая строка слева направо, вторая строка справа налево, третья строка слева направо, четвертая строка справа налево и т. д.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int m, n;\n    cin >> m >> n;\n    int a[255][255];\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n; ++j)\n            cin >> a[i][j];\n    }\n    for (int i = 0; i < m; ++i) {        \n        if (i % 2 == 0)\n            for (int j = 0; j < n; ++j)\n                cout << a[i][j] << \" \";\n        else\n            for (int j = n - 1; j >= 0; --j)\n                cout << a[i][j] << \" \";\n        cout << endl;\n    }\n    return 0;\n}";
                        break;
                    case 12:
                        richTextBox1.Text = "Дана матрица размера M × N. Вывести ее элементы в следующем порядке: первый столбец сверху вниз, второй столбец снизу вверх, третий столбец сверху вниз, четвертый столбец снизу вверх и т. д.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int m, n;\n    cin >> m >> n;\n    int a[255][255];\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n; ++j)\n            cin >> a[i][j];\n    }\n    for (int i = 0; i < n; ++i) {        \n        if (i % 2 == 0)\n            for (int j = 0; j < m; ++j)\n                cout << a[j][i] << \" \";\n        else\n            for (int j = m - 1; j >= 0; --j)\n                cout << a[j][i] << ' ';\n        cout << endl;\n    }\n    return 0;\n}";
                        break;
                    case 13:
                        richTextBox1.Text = "Дана квадратная матрица A порядка M. Начиная с элемента A1,1, вывести ее элементы следующим образом («уголками»): все элементы первой строки; элементы последнего столбца, кроме первого (уже выведенного) элемента; оставшиеся элементы второй строки; оставшиеся элементы предпоследнего столбца и т. д.; последним выводится элемент AM,1.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int m, n;\n    cin >> m >> n;\n    int a[255][255];\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n; ++j)\n            cin >> a[i][j];\n    }\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n - i; ++j)\n            cout << a[i][j] << \' \';\n        for (int j = i + 1; j < m; ++j)\n            cout << a[j][n - 1 - i] << \' \';\n    }\n    return 0;\n}";
                        break;
                    case 14:
                        richTextBox1.Text = "Дана квадратная матрица A порядка M. Начиная с элемента A1,1, вывести ее элементы следующим образом («уголками»): все элементы первого столбца; элементы последней строки, кроме первого (уже выведенного) элемента; оставшиеся элементы второго столбца; оставшиеся элементы предпоследней строки и т. д.; последним выводится элемент A1,M.";
                        richTextBox2.Text = "#include <bits/stdc++.h>\n\nusing namespace std;\n\nint main()\n{ \n    system(\"chcp 1251\");\n    int m;\n    cin >> m;\n    vector<vector<int> > a(m, vector<int>(m));\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < m; ++j) {            \n            cin >> a[i][j];  \n        }\n    }\n    cout << \"Результат: \" << endl;\n    for (int i = 0; i < m; ++i) {        \n            \n        for (int j = 0; j < m - i; ++j) {            \n            cout << a[j][i] << \" \";\n        }\n        \n        for (int j = i + 1; j < m; ++j) {            \n            cout << a[m - i - 1][j] << \" \";\n        }\n    }\n    return 0;\n}";
                        break;
                    case 15:
                        richTextBox1.Text = "Дана квадратная матрица A порядка M (M — нечетное число). Начиная с элемента A1,1 и перемещаясь по часовой стрелке, вывести все ее элементы по спирали: первая строка, последний столбец, последняя строка в обратном порядке, первый столбец в обратном порядке, оставшиеся элементы второй строки и т. д.; последним выводится центральный элемент матрицы.";
                        richTextBox2.Text = "#include <bits/stdc++.h>\nusing namespace std;\nint main()\n{ \n    int m;\n    cin >> m;\n    vector< vector<int> > a(m, vector<int>(m));\n    for (int i = 0; i < m / 2; ++i) {        \n        for (int j = i; j < m - i; ++j)\n            cin >> a[i][j];\n        for (int j = 1 + i; j < m - i; ++j)\n            cin >> a[j][m - i - 1];\n        for (int j = m - i - 2; j >= i; --j)\n            cin >> a[m - i - 1][j];\n        for (int j = m - 2 - i; j >= i + 1; --j)\n            cin >> a[j][i];\n    }\n    cin >> a[m / 2][m / 2];\n    for (auto i : a) {        \n        for (auto j : i)\n            cout << j << ' ';\n        cout << endl;\n    }\n    return 0;\n}";
                        break;
                    case 16:
                        richTextBox1.Text = "Дана квадратная матрица A порядка M (M — нечетное число). Начиная с элемента A1,1 и перемещаясь против часовой стрелки, вывести все ее элементы по спирали: первый столбец, последняя строка, последний столбец в обратном порядке, первая строка в обратном порядке, оставшиеся элементы второго столбца и т. д.; последним выводится центральный элемент матрицы.";
                        richTextBox2.Text = "#include <bits/stdc++.h>\nusing namespace std;\nint main()\n{    \n    system(\"chcp 1251\");\n    srand(time(0));\n    int n;\n    cin >> n;\n    vector <vector < int > > ar(n, vector < int >(n));\n    for (size_t i = 0;i < ar.size();++i)\n        for (size_t j = 0;j < ar.size();++j)\n            ar[i][j] = rand() % 90 + 10;\n    for (auto i : ar) {        \n        for (auto j : i)\n            cout << j << \" \";\n        cout << endl;\n    }\n    cout << endl;\n    for (int i = 0;i < ar.size() / 2 + 1;++i)\n    { \n        for (size_t j = i;j < ar.size() - i;++j)\n            cout << ar[j][i] << \" \";\n        for (size_t j = i + 1;j < ar.size() - i;++j)\n            cout << ar[ar.size() - 1 - i][j] << \" \";\n        for (size_t j = ar.size() - 2 - i;(int)j >= i;--j)\n            cout << ar[j][ar.size() - 1 - i] << \" \";\n        for (size_t j = ar.size() - 2 - i;j > i;--j)\n            cout << ar[i][j] << \" \";\n    }\n    return 0;\n}";
                        break;
                    case 17:
                        richTextBox1.Text = "Дана матрица размера M × N и целое число K (1 ≤ K ≤ M). Найти сумму и произведение элементов K-й строки данной матрицы.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int m, n, k, s = 0, p = 1;\n    cin >> m >> n >> k;\n    int a[255][255];\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n; ++j)\n            cin >> a[i][j];\n    }\n    for (int i = 0; i < n; ++i) {        \n        s += a[k - 1][i];\n        p *= a[k - 1][i];\n    }\n    cout << s << \" \" << p;\n    return 0;\n}";
                        break;
                    case 18:
                        richTextBox1.Text = "Дана матрица размера M × N и целое число K (1 ≤ K ≤ N). Найти сумму и произведение элементов K-го столбца данной матрицы.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int m, n, k, s = 0, p = 1;\n    cin >> m >> n >> k;\n    int a[255][255];\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n; ++j)\n            cin >> a[i][j];\n    }\n    for (int i = 0; i < m; ++i) {        \n        s += a[i][k - 1];\n        p *= a[i][k - 1];\n    }\n    cout << s << \" \" << p;\n    return 0;\n}";
                        break;
                    case 19:
                        richTextBox1.Text = "Дана матрица размера M × N. Для каждой строки матрицы найти сумму ее элементов.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    int m, n, k, s = 0;\n    cin >> m >> n;\n    int a[255][255];\n    for (int i = 0; i < m; ++i) {        \n        s = 0;\n        for (int j = 0; j < n; ++j) {            \n            cin >> a[i][j];\n            s += a[i][j];\n        }\n        cout << \"Для \" << i + 1 << \" cтроки сумма равна = \" << s << endl;\n    }\n    cout << s;\n    return 0;\n}";
                        break;
                    case 20:
                        richTextBox1.Text = "Дана матрица размера M × N. Для каждого столбца матрицы найти произведение его элементов.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    int m, n, k, s;\n    cin >> m >> n;\n    int a[255][255];\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n; ++j)\n            cin >> a[i][j];\n    }\n    for (int i = 0; i < n; ++i) {        \n        s = 1;\n        for (int j = 0; j < m; ++j)\n            s *= a[j][i];\n        cout << s << endl;\n    }\n    return 0;\n}";
                        break;
                    case 21:
                        richTextBox1.Text = "Дана матрица размера M × N. Для каждой строки матрицы с нечетным номером (1, 3, …) найти среднее арифметическое ее элементов. Условный оператор не использовать.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    int m, n;\n    cin >> m >> n;\n    int a[255][255];\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n; ++j)\n            cin >> a[i][j];\n    }\n    for (int i = 0; i < m; i += 2) {        \n        double s = 0;\n        for (int j = 0; j < n; ++j)\n            s += a[i][j];\n        cout << s / n << endl;\n    }\n    return 0;\n}";
                        break;
                    case 22:
                        richTextBox1.Text = "Дана матрица размера M × N. Для каждого столбца матрицы с четным номером (2, 4, …) найти сумму его элементов. Условный оператор не использовать.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    int m, n;\n    cin >> m >> n;\n    int a[255][255];\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n; ++j)\n            cin >> a[i][j];\n    }\n    for (int i = 1; i < n; i += 2) {        \n        double s = 0;\n        for (int j = 0; j < m; ++j)\n            s += a[j][i];\n        cout << s << endl;\n    }\n    return 0;\n}";
                        break;
                    case 23:
                        richTextBox1.Text = "Дана матрица размера M × N. В каждой строке матрицы найти минимальный элемент.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    int m, n;\n    cin >> m >> n;\n    int a[m][n];\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n; ++j)\n            cin >> a[i][j];\n    }\n    for (int i = 0; i < m; ++i) {        \n        int mn = INT_MAX;\n        for (int j = 0; j < n; ++j)\n            mn = min(mn, a[i][j]);\n        cout << mn << endl;\n    }\n    return 0;\n}";
                        break;
                    case 24:
                        richTextBox1.Text = "Дана матрица размера M × N. В каждом столбце матрицы найти максимальный элемент.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int a[255][255], n, m,max = 0,temp,index;\n	cin >> m >> n;\n	for (int i = 0; i < m; i++) {		\n		for (int j = 0; j < n;j++) {			\n			cin >> a[i][j];\n		}\n	}\n		\n	for (int i = 0; i < n; i++) {		\n		for (int j = 0; j < m;j++) {			\n			if (a[j][i] > max) {				\n				max = a[j][i];\n			}\n				\n		}\n		cout << max << \" \";\n		max = 0;\n	}\n}\n";
                        break;
                    case 25:
                        richTextBox1.Text = "Дана матрица размера M × N. Найти номер ее строки с наибольшей суммой элементов и вывести данный номер, а также значение наибольшей суммы.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    int m, n, s = 0, res = 0, pos = 0;\n    cin >> m >> n;\n    int a[255][255];\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n; ++j)\n            cin >> a[i][j];\n    }\n    for (int i = 0; i < m; ++i) {        \n        s = 0;\n        for (int j = 0; j < n; ++j)\n            s += a[i][j];\n        if (res < s) {            \n            pos = i + 1;\n            res = s;\n        }\n    }\n    cout << pos << \' \' << res << endl;\n    return 0;\n}";
                        break;
                    case 26:
                        richTextBox1.Text = "Дана матрица размера M × N. Найти номер ее столбца с наименьшим произведением элементов и вывести данный номер, а также значение наименьшего произведения.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    int m, n, s, res = INT_MAX, pos = 0;\n    cin >> m >> n;\n    int a[255][255];\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n; ++j)\n            cin >> a[i][j];\n    }\n    for (int i = 0; i < n; ++i) {        \n        s = 1;\n        for (int j = 0; j < m; ++j)\n            s *= a[j][i];\n        if (res > s) {            \n            pos = i + 1;\n            res = s;\n        }\n    }\n    cout << pos << \' \' << res << endl;\n    return 0;\n}";
                        break;
                    case 27:
                        richTextBox1.Text = "Дана матрица размера M × N. Найти максимальный среди минимальных элементов ее строк.";
                        richTextBox2.Text = "#include <iostream>\n#include <algorithm>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"ru\");\n		\n	int a[255][255], n, m, b[10], max;\n	cin >> n >> m;\n		\n	for (int i = 0; i < n; i++) {		\n		for (int j = 0; j < m; j++) {			\n			cin >> a[i][j];\n		}\n	}\n	for (int i = 0; i < n; i++) {		\n		int min = a[i][0];\n		for (int j = 0; j < m; j++) {			\n			if (a[i][j] <= min) {				\n				b[i] = a[i][j];\n					\n			}\n		}\n	}\n	max = b[0];\n	for (int i = 1; i < n; i++) {		\n		if (max < b[i]) {			\n			max = b[i];\n		}\n			\n	}\n	cout << endl << max;\n}";
                        break;
                    case 28:
                        richTextBox1.Text = "Дана матрица размера M × N. Найти минимальный среди максимальных элементов ее столбцов.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int a[255][255], m, n,max,maxmine = 0;\n	cin >> m >> n;\n	for (int i = 0; i < m; i++) {		\n		for (int j = 0; j < n; j++) {			\n			cin >> a[i][j];\n		}\n	}\n		\n	for (int j = 0; j < n; j++) {		\n		max = a[0][j];\n		for (int i = 0; i < m; i++) {			\n			if (a[i][j] > max) max = a[i][j];\n		}\n		if (maxmine > max || j == 0) maxmine = max;\n	}\n	cout << maxmine;\n}";
                        break;
                    case 29:
                        richTextBox1.Text = "Дана матрица размера M × N. В каждой ее строке найти количество элементов, меньших среднего арифметического всех элементов этой строки.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Rus\");\n	int a[255][255], m, n;\n	cin >> m >> n;\n	for (int i = 0; i < m; i++) {		\n		for (int j = 0; j < n; j++) {			\n			cin >> a[i][j];\n		}\n	}\n	int sum, num;\n	float sred;\n				\n	for (int i = 0; i < m;i++) {		\n		sum = 0;\n		for (int j = 0; j < n; j++) {			\n			sum += a[i][j];\n		}\n		sred = sum / n;\n		num = 0;\n		for (int j = 0; j < n; j++) \n			if (a[i][j] < sred) ++num;\n		cout << i + 1 << \", Кол-во элементов: \" << num;\n		cout << endl;\n	}\n		\n}";
                        break;
                    case 30:
                        richTextBox1.Text = "Дана матрица размера M × N. В каждом ее столбце найти количество элементов, больших среднего арифметического всех элементов этого столбца.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Rus\");\n	int a[255][255], m, n;\n	cin >> m >> n;\n	for (int i = 0; i < m; i++) {		\n		for (int j = 0; j < n; j++) {			\n			cin >> a[i][j];\n		}\n	}\n	int sum, num;\n	float sred;\n				\n	for (int j = 0; j < n;j++) {		\n		sum = 0;\n		for (int i = 0; i < m; i++) {			\n			sum += a[i][j];\n		}\n		sred = sum / n;\n		num = 0;\n		for (int i = 0; i < m; i++) \n			if (a[i][j] < sred) ++num;\n		cout << j + 1 << \", Кол-во элементов: \" << num;\n		cout << endl;\n	}\n	}";
                        break;
                    case 31:
                        richTextBox1.Text = "Дана матрица размера M × N. Найти номера строки и столбца для элемента матрицы, наиболее близкого к среднему значению всех ее элементов.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"Rus\");\n	int n, m, a[255][255], min, max, temp[255][255], average, tempn, tempm;\n	cin >> n >> m;\n	for (int i = 0; i < n; i++) {		\n		for (int j = 0; j < m; j++) {			\n			cin >> a[i][j];\n			temp[i][j] = a[i][j];\n		}\n	}\n		\n	for (int k = 0; k < n * m; ++k) {		\n		for (int i = 0; i < n; ++i) {			\n			for (int j = 0; j < m; ++j) {				\n				if (j != m - 1) {					\n					if (a[i][j + 1] < a[i][j]) {						\n						int tmp = a[i][j + 1];\n						a[i][j + 1] = a[i][j];\n						a[i][j] = tmp;\n					}\n				}\n				else {					\n					if ((a[i + 1][0] < a[i][j]) && (i != n - 1)) {						\n						int tmp = a[i + 1][0];\n						a[i + 1][0] = a[i][j];\n						a[i][j] = tmp;\n					}\n				}\n			}\n		}\n	}\n	average = (a[0][0] + a[n - 1][m - 1]) / 2;\n							\n	cout << endl;\n							\n	for (int i = 0; i < n; i++) {		\n		for (int j = 0; j < m;j++) {			\n			if (temp[i][j] == average) {				\n				tempn = i + 1;\n				tempm = j + 1;\n			}\n		}\n	}\n	cout << \"Строка: \" << tempn << endl << \"Столбец: \" << tempm << endl;\n}";
                        break;
                    case 32:
                        richTextBox1.Text = "Дана целочисленная матрица размера M × N. Найти номер первой из ее строк, содержащих равное количество положительных и отрицательных элементов (нулевые элементы матрицы не учитываются). Если таких строк нет, то вывести 0.";
                        richTextBox2.Text = "#include <iostream>\n#include <cmath>\n\nusing namespace std;\n\nint main()\n{	\n	setlocale(LC_ALL, \"Rus\");\n	int N, M, p, n, num, k;\n	cin >> N >> M;\n	for (int i = 0; i < N; i++)\n	{ \n		for (int j = 0; j < M; j++)\n		{ \n			cin >> A[i][j];\n		}\n	}\n	k = 0;\n	for (int i = 0; i < N; i++)\n	{ \n		p = n = 0;\n		for (int j = 0; j < M; j++)\n		{ \n			if (A[i][j] > 0) p++;\n			if (A[i][j] < 0) n++;\n		}\n		if (p == n)\n		{ \n			num = i;\n			k++;\n		}\n	}\n	if (k) {		\n		cout << num + 1 << endl;\n	}\n	else {		\n		cout << 0 << endl;\n	}\n	return 0;\n}";
                        break;
                    case 33:
                        richTextBox1.Text = "Дана целочисленная матрица размера M × N. Найти номер последнего из ее столбцов, содержащих равное количество положительных и отрицательных элементов (нулевые элементы матрицы не учитываются). Если таких столбцов нет, то вывести 0.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int n, m, p, neg;\n    cin >> n >> m;\n    int a[m][n];\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n; ++j)\n            cin >> a[i][j];\n    }\n    for (int i = n - 1; i >= 0; ++i) {        \n        p = 0, neg = 0;\n        for (int j = 0; j < m; ++j) {            \n            if (a[j][i] > 0)\n                ++p;\n            if (a[j][i] < 0)\n                ++neg;\n        }\n        if (p == neg) {            \n            cout << i + 1;\n            return 0;\n        }\n    }\n    cout << 0;\n    return 0;\n}";
                        break;
                    case 34:
                        richTextBox1.Text = "Дана целочисленная матрица размера M × N. Найти номер последней из ее строк, содержащих только четные числа. Если таких строк нет, то вывести 0.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    int m, n, s, res = INT_MAX, pos = 0;\n    cin >> m >> n;\n    int a[255][255];\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n; ++j)\n            cin >> a[i][j];\n    }\n    for (int i = n - 1; i >= 0; --i) {        \n        bool b = true;\n        for (int j = 0; j < m; ++j)\n            if (a[i][j] % 2)\n                b = false;\n        if (b) {            \n            cout << i + 1;\n            return 0;\n        }\n    }\n    cout << 0 << endl;\n    return 0;\n}";
                        break;
                    case 35:
                        richTextBox1.Text = "Дана целочисленная матрица размера M × N. Найти номер первого из ее столбцов, содержащих только нечетные числа. Если таких столбцов нет, то вывести 0.";
                        richTextBox2.Text = "# include <iostream>\n# include <windows.h>\n# include <cmath>\n# include <iomanip>\n# include <fstream>\n# include \"IOMatrix.h\"\nusing namespace std;\nint main()\n{ \n    SetConsoleCP(1251);\n    SetConsoleOutputCP(1251);\n    \n    int matr[RMAX][CMAX];\n    int nr, nc;\n    input(matr, \"Matrix35.txt\", nr, nc);\n    output(matr, nr, nc);\n    \n    int numdercol = 0;\n    for (int col = 0; col < nc; ++col) {        \n        bool odd = 1;\n        for (int row = 0; row < nr; ++row) {            \n            if (matr[row][col] % 2 == 0) odd = 0;\n        }\n        if (odd) {            \n            numdercol = col + 1;\n            break;\n        }\n    }\n    cout << \"Номер первого столбца, содержащего только нечетные числа = \" << numdercol << endl;\n    system(\"pause\");\n    return 0;\n}";
                        break;
                    case 36:
                        richTextBox1.Text = "Дана целочисленная матрица размера M × N, элементы которой могут принимать значения от 0 до 100. Различные строки матрицы назовем похожими, если совпадают множества чисел, встречающихся в этих строках. Найти количество строк, похожих на первую строку данной матрицы.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int a[255][255], m, n;\n	cin >> m >> n;\n	for (int i = 0; i < m; i++) {		\n		for (int j = 0; j < n; j++) {			\n			cin >> a[i][j];\n		}\n	}\n		\n	int num = 0,j2;\n	for (int i = 1; i < m; i++) {		\n		for (int j = 0; j < n;j++) {			\n			for (j2 = 0;(j2 < n) && (a[0][j] != a[i][j2]); j2++);\n			if (j2 == n)break;\n		}\n		if (i == m) ++num;\n	}\n		\n	cout << num;\n}";
                        break;
                    case 37:
                        richTextBox1.Text = "Дана целочисленная матрица размера M × N, элементы которой могут принимать значения от 0 до 100. Различные столбцы матрицы назовем похожими, если совпадают множества чисел, встречающихся в этих столбцах. Найти количество столбцов, похожих на последний столбец данной матрицы.";
                        richTextBox2.Text = "#include <bits/stdc++.h>\nusing namespace std;\nint main()\n{    \n    int n, m, k = 0;\n    cin >> n >> m;\n    set<int> b;\n    int a[m][n];\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n; ++j)\n            cin >> a[i][j];\n    }\n    for (int i = 0; i < m; ++i) {        \n        b.insert(a[i][n - 1]);\n    }\n    for (int i = 0; i < n - 1; ++i) {        \n        set<int> t;\n        for (int j = 0; j < m; ++j)\n            t.insert(a[i][j]);\n        if (t == b)\n            ++k;\n    }\n    cout << k << endl;\n    return 0;\n}";
                        break;
                    case 38:
                        richTextBox1.Text = "Дана целочисленная матрица размера M × N. Найти количество ее строк, все элементы которых различны.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    int m, n, sum = 0, a[255][255];\n    int stop;\n    cin >> m >> n;\n        \n    for (int i = 0; i < m;i++) {        \n        for (int j = 0; j < n; j++) {            \n            cin >> a[i][j];\n        }\n    }\n        \n    for (int k = 0; k < m; k++) {        \n        stop = 0;\n        for (int i = 0; i < n - 1 && !stop; i++)\n            for (int j = i + 1; j < n; j++) {                \n                if (a[k][i] == a[k][j]) {                    \n                    stop = 1;\n                    break;\n                }\n                if (j == n - 1 && i == n - 2) {                    \n                    sum++;\n                    stop = 1;\n                    break;\n                }\n            }\n    }\n    cout << sum << endl;\n}";
                        break;
                    case 39:
                        richTextBox1.Text = "Дана целочисленная матрица размера M × N. Найти количество ее столбцов, все элементы которых различны.";
                        richTextBox2.Text = "#include <bits/stdc++.h>\nusing namespace std;\nint main()\n{ \n    int m, n, k = 0;\n    cin >> m >> n;\n    vector<vector<int> > a;\n    for (int i = 0; i < m; ++i) {        \n        vector<int> t(n);\n        for (int j = 0; j < n; ++j)\n            cin >> t[j];\n        a.push_back(t);\n    }\n    for (int i = 0; i < n; ++i) {        \n        set<int> s;\n        for (int j = 0; j < m; ++j)\n            s.insert(a[j][i]);\n        if (s.size() == m)\n            ++k;\n    }\n    cout << k;\n    return 0;\n}";
                        break;
                    case 40:
                        richTextBox1.Text = "Дана целочисленная матрица размера M × N. Найти номер последней из ее строк, содержащих максимальное количество одинаковых элементов.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {    \n    int m, n; cin >> m >> n;\n    int a[255][255];\n    int i, j;\n    int num = 0, nume = 0, nummax = 0, j2, row = 0;\n    for (int i = 0; i < m; i++) {        \n        for (int j = 0; j < n; j++) {            \n            cin >> a[i][j];\n        }\n    }\n    for (i = 0; i < m; ++i) {        \n        nume = 0;\n        for (j = 0; j < n; ++j) {            \n            num = 0;\n            for (j2 = 0; j2 < n; ++j2)\n                if (a[i][j] == a[i][j2] && j != j2) ++num;\n            if (num > 0) nume++;\n        }\n        if (nume >= nummax) {            \n            row = i;\n            nummax = nume;\n        }\n    }\n    cout << row + 1;\n}";
                        break;
                    case 41:
                        richTextBox1.Text = "Дана целочисленная матрица размера M × N. Найти номер первого из ее столбцов, содержащих максимальное количество одинаковых элементов.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int a[255][255], m, n;\n	cin >> m >> n;\n	for (int i = 0; i < m; i++) {		\n		for (int j = 0; j < n; j++) {			\n			cin >> a[i][j];\n		}\n	}\n	\n	int num = 0, nume = 0, nummax = 0, i2, column = 0;\n	for (int j = 0; j < n; j++) {		\n		nume = 0;\n		for (int i = 0; i < m;i++) {			\n			num = 0;\n			\n			for (i2 = 0; i2 < m;i2++)\n				if (a[i][j] == a[i2][j] && i != i2) ++num;\n			if (num > 0) nume++;\n		}\n		if (nume > nummax) {			\n			column = j;\n			nummax = nume;\n		}\n	}\n	cout << column + 1;\n}";
                        break;
                    case 42:
                        richTextBox1.Text = "Дана матрица размера M × N. Найти количество ее строк, элементы которых упорядочены по возрастанию.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main()\n{ \n    setlocale(LC_ALL, \"Rus\");\n    int a[255][255], n, m;\n    cin >> n >> m;\n    for (int i = 0; i < n; i++) {        \n        for (int j = 0; j < m; j++) {            \n            cin >> a[i][j];\n        }\n    }\n    bool sorted = true;\n    for (int i = 0; i < n; i++)\n    {        \n        sorted = true;\n        for (int j = 0; j < m - 1; j++)\n            if (a[i][j] > a[i][j + 1])\n            { \n                sorted = false;\n                break;\n            }\n                \n        cout << \"Строка \" << i + 1 << (sorted ? \" сортирован\" : \" не сортирован\")\n            << endl;\n                \n    }\n    return 0;\n}";
                        break;
                    case 43:
                        richTextBox1.Text = "Дана матрица размера M × N. Найти количество ее столбцов, элементы которых упорядочены по убыванию.";
                        richTextBox2.Text = "#include <bits/stdc++.h>\nusing namespace std;\nint main()\n{ \n    int m, n, k = 0;\n    cin >> m >> n;\n    vector<vector<int> > a;\n    for (int i = 0; i < m; ++i) {        \n        vector<int> t(n);\n        for (int j = 0; j < n; ++j)\n            cin >> t[j];\n        a.push_back(t);\n    }\n    for (int i = 0; i < n; ++i) {        \n        bool b = true;\n        for (int j = 1; j < m; ++j)\n            if (a[j][i] >= a[j - 1][i])\n                b = false;\n        if (b)\n            ++k;\n    }\n    cout << k;\n    return 0;\n}";
                        break;
                    case 44:
                        richTextBox1.Text = "Дана матрица размера M × N. Найти минимальный среди элементов тех строк, которые упорядочены либо по возрастанию, либо по убыванию. Если упорядоченные строки в матрице отсутствуют, то вывести 0.";
                        richTextBox2.Text = "#include <bits/stdc++.h>\nusing namespace std;\nint main()\n{ \n    int m, n, k = 0, mn = INFINITY;\n    cin >> m >> n;\n    vector<vector<int> > a;\n    for (int i = 0; i < m; ++i) {        \n        vector<int> t(n);\n        for (int j = 0; j < n; ++j)\n            cin >> t[j];\n        a.push_back(t);\n    }\n    bool c = true;\n    for (int i = 0; i < m; ++i) {        \n        bool b = true, c = true;\n        for (int j = 1; j < n; ++j) {            \n            if (a[i][j] >= a[i][j - 1])\n                c = false;\n            if (a[i][j] <= a[i][j - 1])\n                b = false;\n        }\n        if (b || c) {            \n            for (int j = 0; j < n; ++j)\n                mn = min(mn, a[i][j]);\n            c = false;\n        }\n    }\n    if (c)\n        cout << 0;\n    else\n        cout << mn;\n    return 0;\n}";
                        break;
                    case 45:
                        richTextBox1.Text = "Дана матрица размера M × N. Найти максимальный среди элементов тех столбцов, которые упорядочены либо по возрастанию, либо по убыванию. Если упорядоченные столбцы в матрице отсутствуют, то вывести 0.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main()\n{ \n    int m, n;\n    cin >> m >> n;\n    int a[255][255];\n    int i, j;\n    for (i = 0; i < m; ++i) {        \n        for (j = 0; j < n; ++j) {            \n            cin >> a[i][j];\n        }\n    }\n    for (j = 0; j < n; ++j) {        \n        for (i = 1; (a[i - 1][j] <= a[i][j] && (i < m)); ++i);\n        if (i == m) cout << a[m - 1][j] << endl;\n        else {            \n            for (i = 1;(a[i - 1][j] > a[i][j] && (i < m)); ++i);\n            if (i == m) cout << a[0][j] << endl;\n            else cout << 0 << endl;\n        }\n    }\n    return 0;\n}";
                        break;
                    case 46:
                        richTextBox1.Text = "Дана целочисленная матрица размера M × N. Найти элемент, являющийся максимальным в своей строке и минимальным в своем столбце. Если такой элемент отсутствует, то вывести 0.";
                        richTextBox2.Text = "#include <iostream>\n#include <algorithm>\n\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"ru\");\n		\n	int a[255][255], n, m, b[255];\n	cin >> n >> m;\n	\n	for (int i = 0; i < n; i++) {\n		for (int j = 0; j < m; j++) {			\n			cin >> a[i][j];\n		}\n	}\n	int max, min;\n	for (int i = 0; i < n; i++) {		\n		max = a[i][0];\n		for (int j = 0; j < m; j++) {			\n			min = a[0][j];\n			if (a[i][j] >= max) {				\n				max = a[i][j];\n			}\n			if (a[i][j] <= min) {				\n				min = a[i][j];\n			}\n				\n		}\n			\n	}\n	cout << endl;\n	cout << \"max: \" << max << endl;\n	cout << \"min: \" << min << endl;\n					\n}";
                        break;
                    case 47:
                        richTextBox1.Text = "Дана матрица размера M × N и целые числа K1 и K2 (1 ≤ K1 < K2 ≤ M). Поменять местами строки матрицы с номерами K1 и K2 .";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"RUS\");\n	int a[255][255], m, n, k1, k2;\n	cout << \"M: \";\n	cin >> m;\n	cout << \"N: \";\n	cin >> n;\n	cout << \"Размер матрицы: \" << endl;\n	for (int i = 0; i < m;i++) {		\n		for (int j = 0;j < n;j++) {			\n			cin >> a[i][j];\n		}\n	}\n		\n	cout << \"K1: \";\n	cin >> k1;\n	cout << \"K2: \";\n	cin >> k2;\n				\n	--k1;\n	--k2;\n	for (int j = 0;j < n;j++) {		\n		a[k1][j] = a[k2][j] + a[k1][j];\n		a[k2][j] = a[k1][j] - a[k2][j];\n		a[k1][j] = a[k1][j] - a[k2][j];\n	}\n		\n	for (int i = 0; i < m;i++) {		\n		for (int j = 0; j < n;j++) {			\n			cout << a[i][j];\n		}\n		cout << endl;\n	}\n}";
                        break;
                    case 48:
                        richTextBox1.Text = "Дана матрица размера M × N и целые числа K1 и K2 (1 ≤ K1 < K2 ≤ N). Поменять местами столбцы матрицы с номерами K1 и K2 .";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"RUS\");\n	int a[255][255], m, n, k1, k2;\n	cout << \"M: \";\n	cin >> m;\n	cout << \"N: \";\n	cin >> n;\n	cout << \"Размер матрицы: \" << endl;\n	for (int i = 0; i < m;i++) {		\n		for (int j = 0;j < n;j++) {			\n			cin >> a[i][j];\n		}\n	}\n		\n	cout << \"K1: \";\n	cin >> k1;\n	cout << \"K2: \";\n	cin >> k2;\n				\n	--k1;\n	--k2;\n	for (int i = 0;i < m;i++) {		\n		a[i][k1] = a[i][k2] + a[i][k1];\n		a[i][k2] = a[i][k1] - a[i][k2];\n		a[i][k1] = a[i][k1] - a[i][k2];\n	}\n		\n	for (int i = 0; i < m;i++) {		\n		for (int j = 0; j < n;j++) {			\n			cout << a[i][j];\n		}\n		cout << endl;\n	}\n}";
                        break;
                    case 49:
                        richTextBox1.Text = "Дана матрица размера M × N. Преобразовать матрицу, поменяв местами минимальный и максимальный элемент в каждой строке.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"RUS\");\n	int a[255][255], m, n, k1, k2;\n	cout << \"M: \";\n	cin >> m;\n	cout << \"N: \";\n	cin >> n;\n	cout << \"Размер матрицы: \" << endl;\n	for (int i = 0; i < m;i++) {		\n		for (int j = 0;j < n;j++) {			\n			cin >> a[i][j];\n		}\n	}\n		\n	int max, min;\n	for (int i = 0;i < m;i++) {		\n		max = min = 0;\n		for (int j = 1; j < n;j++) {			\n			if (a[i][j] > a[i][max]) max = j;\n			if (a[i][j] < a[i][min]) min = j;\n		}\n		a[i][min] = a[i][max] + a[i][min];\n		a[i][max] = a[i][min] - a[i][min];\n		a[i][min] = a[i][min] - a[i][max];\n	}\n		\n	for (int i = 0; i < m;i++) {		\n		for (int j = 0; j < n;j++) {\n			cout << a[i][j];\n		}\n		cout << endl;\n	}\n}";
                        break;
                    case 50:
                        richTextBox1.Text = "Дана матрица размера M × N. Преобразовать матрицу, поменяв местами минимальный и максимальный элемент в каждом столбце.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	setlocale(LC_ALL, \"RUS\");\n	int a[255][255], m, n, k1, k2;\n	cout << \"M: \";\n	cin >> m;\n	cout << \"N: \";\n	cin >> n;\n	cout << \"Размер матрицы: \" << endl;\n	for (int i = 0; i < m;i++) {		\n		for (int j = 0;j < n;j++) {			\n			cin >> a[i][j];\n		}\n	}\n		\n	int max, min;\n	for (int j = 0;j < n;j++) {		\n		max = min = 0;\n		for (int i = 1;i < m;i++) {			\n			if (a[i][j] > a[max][j]) max = i;\n			if (a[i][j] < a[min][j]) min = i;\n		}\n		a[min][j] = a[max][j] + a[min][j];\n		a[max][j] = a[min][j] - a[max][j];\n		a[min][j] = a[min][j] - a[max][j];\n	}\n			\n	for (int i = 0; i < m;i++) {		\n		for (int j = 0; j < n;j++) {			\n			cout << a[i][j];\n		}\n		cout << endl;\n	}\n}";
                        break;
                    case 51:
                        richTextBox1.Text = "Дана матрица размера M × N. Поменять местами строки, содержащие минимальный и максимальный элементы матрицы.";
                        richTextBox2.Text = "#include <iostream>\n#include <algorithm>\nusing namespace std;\nint main()\n{ \n    setlocale(LC_ALL, \"\");\n    int H, W, max_index, min_index, M[255][255];\n    cin >> H >> W;\n    double max, min;\n\n    for (int i = 0; i < H; i++) {        \n        for (int j = 0; j < W; j++) {            \n            cin >> M[i][j];\n        }\n    }\n\n    max = min = M[0][0];\n    max_index = min_index = 0;\n                \n    for (int j = 0; j < W; j++)\n    { \n        for (int i = 0; i < H; i++)\n        { \n            if (max < M[i][j])\n            { \n                max = M[i][j];\n                max_index = j;\n            }\n                \n            if (min > M[i][j])\n            { \n                min = M[i][j];\n                min_index = j;\n            }\n        }\n    }\n        \n    cout << endl;\n                \n    if (max_index == min_index) {        \n        for (int i = 0; i < H; i++)\n        { \n            for (int j = 0; j < W; j++) {                \n                cout << M[i][j] << \" \";\n            }\n            cout << endl;\n        }\n    }\n    else\n    { \n        for (int i = 0; i < H; i++)\n            swap(M[i][max_index], M[i][min_index]);\n            \n        for (int i = 0; i < H; i++)\n        { \n            for (int j = 0; j < W; j++) {                \n                cout << M[i][j] << \" \";\n            }\n            cout << endl;\n        }\n            \n    }\n        \n}";
                        break;
                    case 52:
                        richTextBox1.Text = "Дана матрица размера M × N. Поменять местами столбцы, содержащие минимальный и максимальный элементы матрицы.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nvoid swap(int x, int y) {	\n	if (x != y) {		\n		x += y;\n		y = x - y;\n		x -= y;\n	}\n}\n\nint main() {			\n	int a[255][255], m, n;\n	cin >> m >> n;\n	for (int i = 0; i < m;i++) {		\n		for (int j = 0;j < n;j++) {			\n			cin >> a[i][j];\n		}\n	}\n		\n	int maxI = 1, maxJ = 1, minI = 1, minJ = 1;\n				\n	for (int j = 0; j < n;j++) {		\n		for (int i = 0;i < m;i++) {			\n			if (a[i][j] > a[maxI][maxJ]) {				\n				maxI = i;\n				maxJ = j;\n			}\n			if (a[i][j] < a[minI][minJ]) {				\n				minI = i;\n				minJ = j;\n					\n			}\n		}\n	}\n		\n	if(minJ!=maxJ)\n		for (int i = 0;i < m;i++) {			\n			swap(a[i][minJ], a[i][maxJ]);\n		}\n			\n	for (int i = 0;i < m;i++) {		\n		for (int j = 0;j < n;j++) {			\n			cout << a[i][j];\n		}\n		cout << endl;\n	}\n}";
                        break;
                    case 53:
                        richTextBox1.Text = "Дана матрица размера M × N. Поменять местами столбец с номером 1 и последний из столбцов, содержащих только положительные элементы. Если требуемых столбцов нет, то вывести матрицу без изменений.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nvoid swap(int x, int y) {	\n	if (x != y) {		\n		x += y;\n		y = x - y;\n		x -= y;\n	}\n}\n\nint main() {			\n	int a[255][255], m, n;\n	cin >> m >> n;\n	for (int i = 0; i < m;i++) {		\n		for (int j = 0;j < n;j++) {			\n			cin >> a[i][j];\n		}\n	}\n		\n	int num = -1;\n				\n	for (int j = 1;j < m;j++) {		\n		for (int i = 0;i < n;i++) {			\n			if (a[i][j] <= 0) break;\n			if (i == n) num = j;\n		}\n	}\n		\n	if(num >= 0)\n		for (int i = 0;i < m;i++) {			\n			swap(a[i][0], a[i][num]);\n		}\n			\n	for (int i = 0;i < m;i++) {		\n		for (int j = 0;j < n;j++) {			\n			cout << a[i][j];\n		}\n		cout << endl;\n	}\n}";
                        break;
                    case 54:
                        richTextBox1.Text = "Дана матрица размера M × N. Поменять местами столбец с номером N и первый из столбцов, содержащих только отрицательные элементы. Если требуемых столбцов нет, то вывести матрицу без изменений.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nvoid swap(int x, int y) {	\n	if (x != y) {		\n		x += y;\n		y = x - y;\n		x -= y;\n	}\n}\n\nint main() {			\n	int a[255][255], m, n;\n	cin >> m >> n;\n	for (int i = 0; i < m;i++) {		\n		for (int j = 0;j < n;j++) {			\n			cin >> a[i][j];\n		}\n	}\n		\n	int num = -1;\n				\n	for (int j = 0;j < m-1;j++) {		\n		for (int i = 0;i < n;i++) {			\n			if (a[i][j] >= 0) break;\n			if (i == n) {				\n				num = j;\n				break;\n			}\n		}\n	}\n		\n	if(num >= 0)\n		for (int i = 0;i < m;i++) {			\n			swap(a[i][m-1], a[i][num]);\n		}\n			\n	for (int i = 0;i < m;i++) {		\n		for (int j = 0;j < n;j++) {			\n			cout << a[i][j];\n		}\n		cout << endl;\n	}\n}";
                        break;
                    case 55:
                        richTextBox1.Text = "Дана матрица размера M × N (M — четное число). Поменять местами верхнюю и нижнюю половины матрицы.";
                        richTextBox2.Text = "#include <iostream>\n#include <algorithm>\nusing namespace std;\n\nint main() {	\n	int m, n, a[255][255], temp[255][255], tempp[255][255];\n	cin >> m >> n;\n	for (int i = 0; i < m; i++) {		\n		for (int j = 0; j < n;j++) {			\n			cin >> a[i][j];\n			temp[i][j] = a[i][j];\n		}\n	}\n		\n	for (int i = 0; i < m / 2; i++) {		\n		for (int j = 0; j < n;j++) {			\n			swap(a[i + m / 2][j], a[i][j]);\n		}\n	}\n	cout << endl;\n	for (int i = 0; i < m;i++) {		\n		for (int j = 0; j < n;j++) {			\n			cout << a[i][j] << \" \";\n		}\n		cout << endl;\n	}\n}";
                        break;
                    case 56:
                        richTextBox1.Text = "Дана матрица размера M × N (N — четное число). Поменять местами левую и правую половины матрицы.";
                        richTextBox2.Text = "#include <iostream>\n#include <algorithm>\nusing namespace std;\n\nint main() {	\n	int m, n, a[255][255], temp[255][255], tempp[255][255];\n	cin >> m >> n;\n	for (int i = 0; i < m; i++) {		\n		for (int j = 0; j < n;j++) {			\n			cin >> a[i][j];\n			temp[i][j] = a[i][j];\n		}\n	}\n		\n	for (int i = 0; i < m; i++) {		\n		for (int j = 0; j < n / 2;j++) {			\n			swap(a[i][j + n / 2], a[i][j]);\n		}\n	}\n	cout << endl;\n	for (int i = 0; i < m;i++) {		\n		for (int j = 0; j < n;j++) {			\n			cout << a[i][j] << \" \";\n		}\n		cout << endl;\n	}\n}";
                        break;
                    case 57:
                        richTextBox1.Text = "Дана матрица размера M × N (M и N — четные числа). Поменять местами левую верхнюю и правую нижнюю четверти матрицы.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nvoid swap(int x, int y) {	\n	if (x != y) {		\n		x += y;\n		y = x - y;\n		x -= y;\n	}\n}\n\nint main() {			\n	int a[255][255], m, n;\n	cin >> m >> n;\n	for (int i = 0;i < m;i++) {		\n		for (int j = 0;j < n;j++) {			\n			cin >> a[i][j];\n		}\n	}\n		\n	for (int i = 0; i < m / 2;i++) {		\n		for (int j = 0; j < n / 2; j++)\n			swap(a[i][j], a[m / 2 + i][n / 2 + j]);\n	}\n			\n	for (int i = 0;i < m;i++) {		\n		for (int j = 0; j < n;j++) {			\n			cout << a[i][j] << \" \";\n		}\n		cout << endl;\n	}\n}";
                        break;
                    case 58:
                        richTextBox1.Text = "Дана матрица размера M × N (M и N — четные числа). Поменять местами левую нижнюю и правую верхнюю четверти матрицы.";
                        richTextBox2.Text = "#include <iostream>\n#include <algorithm>\nusing namespace std;\n\nint main() {	\n	int a[255][255], m, n;\n	cin >> m >> n;\n		\n	for (int i = 0; i < m;i++) {		\n		for (int j = 0;j < n;j++) {			\n			cin >> a[i][j];\n		}\n	}\n		\n	for (int i = 0;i < m / 2;i++) {		\n		for (int j = 0;j < n / 2;j++) {			\n			swap(a[m / 2 + 1][j], a[i][n / 2 + j]);\n		}\n	}\n		\n	for (int i = 0; i < m;i++) {		\n		for (int j = 0;j < n;j++) {			\n			cout << a[i][j] << \" \";\n		}\n		cout << endl;\n	}\n}";
                        break;
                    case 59:
                        richTextBox1.Text = "Дана матрица размера M × N. Зеркально отразить ее элементы относительно горизонтальной оси симметрии матрицы (при этом поменяются местами строки с номерами 1 и M, 2 и M-1 и т. д.).";
                        richTextBox2.Text = "#include <iostream>\n#include <algorithm>\nusing namespace std;\n\nint main() {	\n	int a[255][255], m, n;\n	cin >> m >> n;\n		\n	for (int i = 0; i < m;i++) {		\n		for (int j = 0;j < n;j++) {			\n			cin >> a[i][j];\n		}\n	}\n		\n	for (int i = 0;i < m / 2;i++) {		\n		for (int j = 0;j < n / 2;j++) 			\n			swap(a[i][j], a[m-i-1][j]);		}\n	}\n		\n	for (int i = 0; i < m;i++) {		\n		for (int j = 0;j < n;j++) {			\n			cout << a[i][j] << \" \";\n		}\n		cout << endl;\n	}\n}";
                        break;
                    case 60:
                        richTextBox1.Text = "Дана матрица размера M × N. Зеркально отразить ее элементы относительно вертикальной оси симметрии матрицы (при этом поменяются местами столбцы с номерами 1 и N, 2 и N-1 и т. д.).";
                        richTextBox2.Text = "#include <iostream>\n#include <algorithm>\nusing namespace std;\n\nint main() {	\n	int a[255][255], m, n;\n	cin >> m >> n;\n		\n	for (int i = 0; i < m;i++) {		\n		for (int j = 0;j < n;j++) {			\n			cin >> a[i][j];\n		}\n	}\n		\n	for (int i = 0;i < m;i++) {		\n		for (int j = 0;j < n / 2;j++) {			\n			swap(a[i][j], a[i][n-j-1]);\n		}\n	}\n		\n	for (int i = 0; i < m;i++) {		\n		for (int j = 0;j < n;j++) {			\n			cout << a[i][j] << \" \";\n		}\n		cout << endl;\n	}\n}";
                        break;
                    case 61:
                        richTextBox1.Text = "Дана матрица размера M × N и целое число K (1 ≤ K ≤ M). Удалить строку матрицы с номером K.";
                        richTextBox2.Text = "#include <bits/stdc++.h>\nusing namespace std;\nint main()\n{ \n    int m, n, k;\n    cin >> m >> n >> k;\n    vector<int> t(n);\n    vector<vector<int> > a;\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n; ++j)\n            cin >> t[j];\n        a.push_back(t);\n    }\n    a.erase(a.begin() + k - 1);\n    for (auto i : a) {        \n        for (auto j : i)\n            cout << j << \" \";\n        cout << endl;\n    }\n        \n    return 0;\n}";
                        break;
                    case 62:
                        richTextBox1.Text = "Дана матрица размера M × N и целое число K (1 ≤ K ≤ N). Удалить столбец матрицы с номером K.";
                        richTextBox2.Text = "#include <iostream>\n#include <windows.h>\n#include <cmath>\n#include <iomanip>\n#include <fstream>\n#include \"IOMatrix.h\"\nusing namespace std;\nint main()\n{ \n	SetConsoleCP(1251);\n	SetConsoleOutputCP(1251);\n	double matr[RMAX][CMAX];\n	int nr, nc;\n	input(matr, \"Matrix62.txt\", nr, nc);\n	output(matr, nr, nc);\n	cout << endl;\n	int K;\n	cout << \"Введите число K:\" << endl;\n	cin >> K;\n	for (int col = K; col < nc; ++col) {		\n		for (int row = 0; row < nr; ++row) {			\n			matr[row][col - 1] = matr[row][col];\n				\n		}\n		cout << endl;\n	}\n	cout << \"Преобразованная матрица\" << endl;\n	output(matr, nr, --nc);\n	system(\"pause\");\n	return 0;\n}";
                        break;
                    case 63:
                        richTextBox1.Text = "Дана матрица размера M × N. Удалить строку, содержащую минимальный элемент матрицы.";
                        richTextBox2.Text = "#include <bits/stdc++.h>\nusing namespace std;\nint main()\n{ \n    int m, n, k = INT_MAX, pos = 0;\n    cin >> m >> n;\n    vector<int> t(n);\n    vector<vector<int> > a;\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n; ++j) {            \n            cin >> t[j];\n            if (k > t[j]) {                \n                k = t[j];\n                pos = i;\n            }\n        }\n        a.push_back(t);\n    }\n    a.erase(a.begin() + pos - 1);\n    for (auto i : a) {        \n        for (auto j : i)\n            cout << j << \" \";\n        cout << endl;\n    }\n    return 0;\n}";
                        break;
                    case 64:
                        richTextBox1.Text = "Дана матрица размера M × N. Удалить столбец, содержащий максимальный элемент матрицы.";
                        richTextBox2.Text = "#include <bits/stdc++.h>\nusing namespace std;\nint main()\n{ \n    int m, n, k = INT_MIN, pos = 0;\n    cin >> m >> n;\n    vector<int> t(n);\n    vector<vector<int> > a;\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n; ++j) {            \n            cin >> t[j];\n            if (k < t[j]) {                \n                k = t[j];\n                pos = j;\n            }\n        }\n        a.push_back(t);\n    }\n    for (int i = 0; i < a.size(); ++i) {        \n        a.at(i).erase(a.at(i).begin() + pos);\n    }\n    for (auto i : a) {        \n        for (auto j : i)\n            cout << j << \" \";\n        cout << endl;\n    }\n    return 0;\n}";
                        break;
                    case 65:
                        richTextBox1.Text = "Дана матрица размера M × N. Удалить ее первый столбец, содержащий только положительные элементы. Если требуемых столбцов нет, то вывести матрицу без изменений.";
                        richTextBox2.Text = "#include <bits/stdc++.h>\nusing namespace std;\nint main()\n{ \n    int m, n, pos = -1;\n    cin >> m >> n;\n    vector<int> t(n);\n    vector<vector<int> > a;\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n; ++j)\n            cin >> t[j];\n        a.push_back(t);\n    }\n    for (int i = 0; i < n; ++i) {        \n        bool b = true;\n        for (int j = 0; j < m; ++j)\n            if (a[j][i] <= 0)\n                b = false;\n        if (b) {            \n            pos = i;\n            break;\n        }\n    }\n    if (pos > -1)\n        for (int i = 0; i < a.size(); ++i) {            \n            a.at(i).erase(a.at(i).begin() + pos);\n        }\n    for (auto i : a) {        \n        for (auto j : i)\n            cout << j << \" \";\n        cout << endl;\n    }\n    return 0;\n}";
                        break;
                    case 66:
                        richTextBox1.Text = "Дана матрица размера M × N. Удалить ее последний столбец, содержащий только отрицательные элементы. Если требуемых столбцов нет, то вывести матрицу без изменений.";
                        richTextBox2.Text = "#include <bits/stdc++.h>\nusing namespace std;\nint main()\n{ \n    int m, n, pos = -1;\n    cin >> m >> n;\n    vector<int> t(n);\n    vector<vector<int> > a;\n    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n; ++j)\n            cin >> t[j];\n        a.push_back(t);\n    }\n    for (int i = n - 1; i >= 0; --i) {        \n        bool b = true;\n        for (int j = 0; j < m; ++j)\n            if (a[j][i] >= 0)\n                b = false;\n        if (b) {            \n            pos = i;\n            break;\n        }\n    }\n    if (pos > -1)\n        for (int i = 0; i < a.size(); ++i) {            \n            a.at(i).erase(a.at(i).begin() + pos);\n        }\n    for (auto i : a) {        \n        for (auto j : i)\n            cout << j << \" \";\n        cout << endl;\n    }\n    return 0;\n}";
                        break;
                    case 67:
                        richTextBox1.Text = "Дана матрица размера M × N, содержащая как положительные, так и отрицательные элементы. Удалить все ее столбцы, содержащие только положительные элементы. Если требуемых столбцов нет, то вывести матрицу без изменений.";
                        richTextBox2.Text = "#include <bits/stdc++.h>\nusing namespace std;\nint main()\n{ \n    int m, n;\n    cin >> m >> n;\n    vector<int> t(n);\n    vector<vector<int> > a;    for (int i = 0; i < m; ++i) {        \n        for (int j = 0; j < n; ++j)\n            cin >> t[j];\n        a.push_back(t);\n    }\n    for (int i = n - 1; i >= 0; --i) {        \n        bool b = true;\n        for (int j = 0; j < a.at(i).size(); ++j)\n            if (a[j][i] <= 0)\n                b = false;\n        if (b)\n            for (int k = 0; k < a.size(); ++k)\n                a.at(k).erase(a.at(k).begin() + i);\n    }\n    for (auto i : a) {        \n        for (auto j : i)\n            cout << j << \" \";\n        cout << endl;\n    }\n    return 0;\n}";
                        break;
                    case 68:
                        richTextBox1.Text = "Дана матрица размера M × N и целое число K (1 ≤ K ≤ M). Перед строкой матрицы с номером K вставить строку из нулей.";
                        richTextBox2.Text = "#include <bits/stdc++.h>\nusing namespace std;\nint main()\n{ \n    int m, n, k;\n    cin >> m >> n >> k;\n    vector<vector<int> > a;\n    for (int i = 0; i < m + 1; ++i) {        \n        vector<int> t(n);\n        if (i == k - 1)\n            a.push_back(t);\n        else {            \n            for (int j = 0; j < n; ++j)\n                cin >> t[j];\n            a.push_back(t);\n        }\n    }\n    for (auto i : a) {        \n        for (auto j : i)\n            cout << j << \" \";\n        cout << endl;\n    }\n    return 0;\n}";
                        break;
                    case 69:
                        richTextBox1.Text = "Дана матрица размера M × N и целое число K (1 ≤ K ≤ N). После столбца матрицы с номером K вставить столбец из единиц.";
                        richTextBox2.Text = "#include <bits/stdc++.h>\nusing namespace std;\nint main()\n{ \n    int m, n, k;\n    cin >> m >> n >> k;\n    vector<vector<int> > a;\n    for (int i = 0; i < m; ++i) {        \n        vector<int> t(n + 1);\n        for (int j = 0; j < n + 1; ++j)\n            if (j == k)\n                ++t[j];\n            else\n                cin >> t[j];\n        a.push_back(t);\n    }\n    for (auto i : a) {        \n        for (auto j : i)\n            cout << j << \" \";\n        cout << endl;\n    }\n    return 0;\n}";
                        break;
                    case 70:
                        richTextBox1.Text = "Дана матрица размера M × N. Продублировать строку матрицы, содержащую ее максимальный элемент.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int a[255][255], m, n;\n	cin >> m >> n;\n		\n	for (int i = 0; i < m;i++) {		\n		for (int j = 0;j < n;j++) {			\n			cin >> a[i][j];\n		}\n	}\n	cout << endl;\n	int maxi = 0, maxj = 0;\n	for (int i = 0; i < m;i++) {		\n		for (int j = 0; j < n; j++) {			\n			if (a[i][j] > a[maxi][maxj]) {				\n				maxi = i;\n				maxj = j;\n			}\n		}\n	}\n		\n	++m;\n	for (int i = m - 1;i > maxi;i--) {		\n		for (int j = 0;j < n;j++)\n			a[i][j] = a[i - 1][j];\n	}\n		\n	for (int i = 0; i < m;i++) {		\n		for (int j = 0;j < n;j++) {			\n			cout << a[i][j] << \" \";\n		}\n		cout << endl;\n	}\n}";
                        break;
                    case 71:
                        richTextBox1.Text = "Дана матрица размера M × N. Продублировать столбец матрицы, содержащий ее минимальный элемент.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int a[255][255], m, n;\n	cin >> m >> n;\n		\n	for (int i = 0; i < m;i++) {		\n		for (int j = 0;j < n;j++) {			\n			cin >> a[i][j];\n		}\n	}\n	cout << endl;\n	int mini = 0, maxj = 0;\n	for (int i = 0; i < m;i++) {		\n		for (int j = 0; j < n; j++) {			\n			if (a[i][j] < a[mini][maxj]) {				\n				mini = i;\n				maxj = j;\n			}\n		}\n	}\n		\n	++n;\n	for (int j = n - 1;j > maxj;j--) {		\n		for (int i = 0;i < n;i++)\n			a[i][j] = a[i][j-1];\n	}\n		\n	for (int i = 0; i < m;i++) {		\n		for (int j = 0;j < n;j++) {			\n			cout << a[i][j] << \" \";\n		}\n		cout << endl;\n	}\n}";
                        break;
                    case 72:
                        richTextBox1.Text = "Дана матрица размера M × N. Перед первым столбцом, содержащим только положительные элементы, вставить столбец из единиц. Если требуемых столбцов нет, то вывести матрицу без изменений.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int i, j;\n	int a[255][255], m, n;\n	cin >> m >> n;\n		\n	for (i = 0; i < m;i++) {		\n		for (j = 0;j < n;j++) {			\n			cin >> a[i][j];\n		}\n	}\n	cout << endl;\n				\n	for (j = 0;j < n;j++) {		\n		for (i = 0;i < m;i++) {			\n			if (a[i][j] < 0) break;\n		}\n		if (i == n) break;\n	}\n		\n	int column = j;\n	++n;\n	for (j = n - 1;j > column;j--)\n		for (i = 0;i < n;i++)\n			a[i][j] = a[i][j - 1];\n			\n	for (i = 0; i < m;i++) {		\n		for (j = 0;j < n;j++) {			\n			cout << a[i][j] << \" \";\n		}\n		cout << endl;\n	}\n}";
                        break;
                    case 73:
                        richTextBox1.Text = "Дана матрица размера M × N. После последнего столбца, содержащего только отрицательные элементы, вставить столбец из нулей. Если требуемых столбцов нет, то вывести матрицу без изменений.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int i, j;\n	int a[255][255], m, n;\n	cin >> m >> n;\n		\n	for (i = 0; i < m;i++) {		\n		for (j = 0;j < n;j++) {			\n			cin >> a[i][j];\n		}\n	}\n	cout << endl;\n				\n	for (j = n-1;j >= 0;j--) {		\n		for (i = 0;i < m;i++) {			\n			if (a[i][j] > 0) break;\n		}\n		if (i == n) break;\n	}\n		\n	int column = j;\n	++n;\n	for (j = n - 1;j > column+1;j--)\n		for (i = 0;i < n;i++)\n			a[i][j] = a[i][j - 1];\n	for (i = 0;i < n;i++) a[i][column + 1] = 0;\n		\n	for (i = 0; i < m;i++) {		\n		for (j = 0;j < n;j++) {			\n			cout << a[i][j] << \" \";\n		}\n		cout << endl;\n	}\n}";
                        break;
                    case 74:
                        richTextBox1.Text = "Дана матрица размера M × N. Элемент матрицы называется ее локальным минимумом, если он меньше всех окружающих его элементов. Заменить все локальные минимумы данной матрицы на нули. При решении допускается использовать вспомогательную матрицу.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int i, j;\n	int a[255][255], m, n,b[255][255];\n	cin >> m >> n;\n		\n	for (i = 0; i < m;i++) {		\n		for (j = 0;j < n;j++) {			\n			cin >> a[i][j];\n		}\n	}\n	cout << endl;\n				\n	int num;\n	for (i = 0;i < m;i++) {		\n		for (j = 0;j < n;j++) {			\n			num = 0;\n			if (i - 1 >= 0) {				\n				if (a[i][j] < a[i - 1][j]) num++;\n			}\n			else ++num;\n			if ((i + 1) < m) {				\n				if (a[i][j] < a[i + 1][j]) num++;\n			}\n			else ++num;\n			if ((j + 1) < n) {				\n				if (a[i][j] < a[i][j + 1]) num++;\n			}\n			else ++num;\n				\n			if (num == 4) b[i][j] = 0;\n			else b[i][j] = a[i][j];\n		}\n	}\n		\n	for (i = 0;i < m;i++)\n		for (j = 0;j < n;j++) a[i][j] = b[i][j];\n			\n	for (i = 0; i < m;i++) {		\n		for (j = 0;j < n;j++) {			\n			cout << a[i][j] << \" \";\n		}\n		cout << endl;\n	}\n}";
                        break;
                    case 75:
                        richTextBox1.Text = "Дана матрица размера M × N. Элемент матрицы называется ее локальным максимумом, если он больше всех окружающих его элементов. Поменять знак всех локальных максимумов данной матрицы на противоположный. При решении допускается использовать вспомогательную матрицу.";
                        richTextBox2.Text = "#include <iostream>\n# include <windows.h>\n# include <cmath>\n# include <iomanip>\n# include <fstream>\n# include \"IOMatrix.h\"\n\nusing namespace std;\n\nint main()\n{ \n	SetConsoleCP(1251);\n	SetConsoleOutputCP(1251);\n	\n	double matr[RMAX][CMAX];\n	int nr, nc;\n	input(matr, \"Matrix75.txt\", nr, nc);\n	output(matr, nr, nc);\n	cout << endl;\n	double matr_reformed[nr][nc];\n	\n	for (int row = 0; row < nr; ++row) {		\n		for (int col = 0; col < nc; ++col) {			\n			if ((row == 0 || col == 0 || matr[row][col] > matr[row - 1][col - 1]) && \n				(row == 0 || matr[row][col] > matr[row - 1][col]) && \n				(row == 0 || col == nc - 1 || matr[row][col] > matr[row - 1][col + 1]) && \n				(col == 0 || matr[row][col] > matr[row][col - 1]) && \n				(col == nc - 1 || matr[row][col] > matr[row][col + 1]) && \n				(row == nr - 1 || col == 0 || matr[row][col] > matr[row + 1][col - 1]) && \n				(row == nr - 1 || matr[row][col] > matr[row + 1][col]) && \n				(row == nr - 1 || col == nc - 1 || matr[row][col] > matr[row + 1][col + 1])) {				\n				matr_reformed[row][col] = -matr[row][col];\n			}\n			else matr_reformed[row][col] = matr[row][col];\n		}\n	}\n	for (int row = 0; row < nr; ++row) {		\n		for (int col = 0; col < nc; ++col) {			\n			matr[row][col] = matr_reformed[row][col];\n		}\n	}\n	output(matr, nr, nc);\n				\n	system(\"pause\");\n	return 0;\n}";
                        break;
                    case 76:
                        richTextBox1.Text = "Дана матрица размера M × N. Упорядочить ее строки так, чтобы их первые элементы образовывали возрастающую последовательность.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main(int argc, char* argv[])\n{ \n    int m, n;\n    cout << \"N: \";\n    cin >> n;\n    cout << \"M: \";\n    cin >> m;\n    int a[10][10];\n    int i, j;\n    for (i = 1; i <= m; ++i) {        \n        cout << i << \" : \" << endl;\n        for (j = 1; j <= n; ++j) {            \n            cout << j << \" : \";\n            cin >> a[i][j];\n        }\n    }\n    int m2 = m, i2;\n    for (i = 1; i < m; ++i) {        \n        i2 = 1;\n        --m2;\n        while (i2 <= m2) {            \n            if (a[i2][1] > a[i2 + 1][1])\n                for (j = 1;j <= n; ++j) {                    \n                    a[i2][j] += a[i2 + 1][j];\n                    a[i2 + 1][j] = a[i2][j] - a[i2 + 1][j];\n                    a[i2][j] = a[i2][j] - a[i2 + 1][j];\n                }\n            ++i2;\n        }\n    }\n    for (i = 1; i <= m; ++i) {        \n        for (j = 1; j <= n; ++j) {            \n            cout << \" : \" << a[i][j];\n        }\n        cout << \" : \" << endl;\n    }\n    return 0;\n}";
                        break;
                    case 77:
                        richTextBox1.Text = "Дана матрица размера M × N. Упорядочить ее столбцы так, чтобы их последние элементы образовывали убывающую последовательность.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int i, j;\n	int a[255][255], m, n, b[255][255];\n	cin >> m >> n;\n	\n	for (i = 0; i < m;i++) {		\n		for (j = 0;j < n;j++) {			\n			cin >> a[i][j];\n		}\n	}\n	cout << endl;\n				\n	int n2 = n, j2;\n	for (j = 0; j < n - 1; ++j) {		\n		j2 = 0;\n		--n2;\n		while (j2 < n2) {			\n			if (a[m - 1][j2] < a[m - 1][j2 + 1])\n				for (i = 0;i < m; ++i) {					\n					a[i][j] += a[i][j2 + 1];\n					a[i][j2 + 1] = a[i][j] - a[i][j2 + 1];\n					a[i][j] = a[i][j] - a[i][j2 + 1];\n				}\n			++j2;\n		}\n	}\n		\n	for (i = 0; i < m;i++) {		\n		for (j = 0;j < n;j++) {			\n			cout << a[i][j] << \" \";\n		}\n		cout << endl;\n	}\n}";
                        break;
                    case 78:
                        richTextBox1.Text = "Дана матрица размера M × N. Упорядочить ее строки так, чтобы их минимальные элементы образовывали убывающую последовательность.";
                        richTextBox2.Text = "";
                        break;
                    case 79:
                        richTextBox1.Text = "Дана матрица размера M × N. Упорядочить ее столбцы так, чтобы их максимальные элементы образовывали возрастающую последовательность.";
                        richTextBox2.Text = "";
                        break;
                    case 80:
                        richTextBox1.Text = "Дана квадратная матрица A порядка M. Найти сумму элементов ее главной диагонали, то есть диагонали, содержащей следующие элементы:\nA1,1, A2,2, A3,3, …, AM,M.";
                        richTextBox2.Text = "";
                        break;
                    case 81:
                        richTextBox1.Text = "Дана квадратная матрица A порядка M. Найти среднее арифметическое элементов ее побочной диагонали, то есть диагонали, содержащей следующие элементы:\nA1,M, A2,M - 1, A3,M - 2, …, AM,1.";
                        richTextBox2.Text = "";
                        break;
                    case 82:
                        richTextBox1.Text = "Дана квадратная матрица A порядка M. Найти сумму элементов каждой ее диагонали, параллельной главной (начиная с одноэлементной диагонали A1,M).";
                        richTextBox2.Text = "";
                        break;
                    case 83:
                        richTextBox1.Text = "Дана квадратная матрица A порядка M. Найти сумму элементов каждой ее диагонали, параллельной побочной (начиная с одноэлементной диагонали A1,1).";
                        richTextBox2.Text = "# include <iostream>\n# include <windows.h>\n# include <cmath>\n# include <iomanip>\n# include <fstream>\n# include \"IOMatrix.h\"\nusing namespace std;\nint main()\n{ \n    SetConsoleCP(1251);\n    SetConsoleOutputCP(1251);\n    double A[RMAX][CMAX];\n    int n;\n    cout << \"Введите порядок матрицы: \";\n    cin >> n;\n    input(A, \"Matrix83.txt\", n, n);\n    output(A, n, n);\n    double sum;\n    for (int row = 0; row < 2 * n - 1; ++row) {        \n        sum = 0;\n        for (int col = 0; col <= row; ++col) {            \n            if (col < n && row - col < n) {                \n                sum += A[col][row - col];\n            }\n        }\n        cout << \"Сумма элементов \" << row << \" диагонали,\";\n        cout << \" параллельной побочной = \" << sum << endl;\n    }\n    system(\"pause\");\n    return 0;\n}";
                        break;
                    case 84:
                        richTextBox1.Text = "Дана квадратная матрица A порядка M. Найти среднее арифметическое элементов каждой ее диагонали, параллельной главной (начиная с одноэлементной диагонали A1,M).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int a[255][255], m,c=0,sum=0,sred;\n	cin >> m;\n		\n	for (int i = 0;i < m;i++) {		\n		for (int j = 0;j < m;j++) {			\n			cin >> a[i][j];\n		}\n	}\n		\n	for (int i = 0;i < m;i++) {		\n		sum += a[i][m - 1 - i];\n		c++;\n	}\n	sred = sum / c;\n	cout << sred;\n}";
                        break;
                    case 85:
                        richTextBox1.Text = "Дана квадратная матрица A порядка M. Найти среднее арифметическое элементов каждой ее диагонали, параллельной побочной (начиная с одноэлементной диагонали A1,1).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int a[255][255], m,c=0,sum=0,sred;\n	cin >> m;\n		\n	for (int i = 0;i < m;i++) {\n		for (int j = 0;j < m;j++) {			\n			cin >> a[i][j];\n		}\n	}\n		\n	for (int i = 0;i < m;i++) {		\n		sum += a[i][i];\n		c++;\n	}\n	sred = sum / c;\n	cout << sred;\n}";
                        break;
                    case 86:
                        richTextBox1.Text = "Дана квадратная матрица A порядка M. Найти минимальный элемент для каждой ее диагонали, параллельной главной (начиная с одноэлементной диагонали A1,M).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int a[255][255], m,min1,min2;\n	cin >> m;\n		\n	for (int i = 0;i < m;i++) {		\n		for (int j = 0;j < m;j++) {			\n			cin >> a[i][j];\n		}\n	}\n	min1 = a[0][m - 1];\n	for (int i = 0;i < m;i++) {		\n		if (a[i][m - 1 - i] < min1) {			\n			min1 = a[i][m - 1 - i];\n		}\n	}\n		\n	min2 = a[0][0];\n	for (int i = 0;i < m;i++) {		\n		if (a[i][i] < min2) {			\n			min1 = a[i][i];\n		}\n	}\n		\n	cout << min1 << \" \" << min2;\n}";
                        break;
                    case 87:
                        richTextBox1.Text = "Дана квадратная матрица A порядка M. Найти максимальный элемент для каждой ее диагонали, параллельной побочной (начиная с одноэлементной диагонали A1,1).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int a[255][255], m,max1,max2;\n	cin >> m;\n		\n	for (int i = 0;i < m;i++) {		\n		for (int j = 0;j < m;j++) {			\n			cin >> a[i][j];\n		}\n	}\n	max1 = a[0][0];\n	for (int i = 0;i < m;i++) {		\n		if (a[i][i] > max1) {			\n			max1 = a[i][i];\n		}\n	}\n		\n	max2 = a[0][m - 1];\n	for (int i = 0;i < m;i++) {		\n		if (a[i][m-1-i] > max2) {			\n			max2 = a[i][m-1-i];\n		}\n	}\n		\n	cout << max1 << \" \" << max2;\n}";
                        break;
                    case 88:
                        richTextBox1.Text = "Дана квадратная матрица порядка M. Обнулить элементы матрицы, лежащие ниже главной диагонали. Условный оператор не использовать.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int a[255][255], m,max1,max2;\n	cin >> m;\n		\n	for (int i = 0;i < m;i++) {		\n		for (int j = 0;j < m;j++) {			\n			cin >> a[i][j];\n		}\n	}\n		\n	for (int i = 0;i < m;i++) {		\n		for (int j = 0;j < m;j++) {			\n			a[i+j+1][i] = 0;\n		}\n	}\n		\n	for (int i = 0;i < m;i++) {		\n		for (int j = 0;j < m;j++) {			\n			cout << a[i][j] << \" \";\n		}\n		cout << endl;\n	}\n}";
                        break;
                    case 89:
                        richTextBox1.Text = "Дана квадратная матрица порядка M. Обнулить элементы матрицы, лежащие выше побочной диагонали. Условный оператор не использовать.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int a[255][255], m,max1,max2;\n	cin >> m;\n		\n	for (int i = 0;i < m;i++) {		\n		for (int j = 0;j < m;j++) {			\n			cin >> a[i][j];\n		}\n	}\n		\n	for (int i = 0;i < m;i++) {		\n		for (int j = m-2;j >= 0;j--) {			\n			a[i][m-2-i-j] = 0;\n		}\n	}\n		\n	for (int i = 0;i < m;i++) {		\n		for (int j = 0;j < m;j++) {			\n			cout << a[i][j] << \" \";\n		}\n		cout << endl;\n	}\n}";
                        break;
                    case 90:
                        richTextBox1.Text = "Дана квадратная матрица порядка M. Обнулить элементы матрицы, лежащие на побочной диагонали и ниже нее. Условный оператор не использовать.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int a[255][255], m,max1,max2;\n	cin >> m;\n		\n	for (int i = 0;i < m;i++) {		\n		for (int j = 0;j < m;j++) {			\n			cin >> a[i][j];\n		}\n	}\n		\n	for (int i = 0;i < m;i++) {		\n		for (int j = 0;j < m;j++) {			\n			a[i][m-1-i+j] = 0;\n		}\n	}\n		\n	for (int i = 0;i < m;i++) {		\n		for (int j = 0;j < m;j++) {			\n			cout << a[i][j] << \" \";\n		}\n		cout << endl;\n	}\n}";
                        break;
                    case 91:
                        richTextBox1.Text = "Дана квадратная матрица порядка M. Обнулить элементы матрицы, лежащие на главной диагонали и выше нее. Условный оператор не использовать.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int a[255][255], m,max1,max2;\n	cin >> m;\n	\n	for (int i = 0;i < m;i++) {		\n		for (int j = 0;j < m;j++) {			\n			cin >> a[i][j];\n		}\n	}\n		\n	for (int i = 0;i < m;i++) {		\n		for (int j = m-1;j >= 0;j--) {			\n			a[i+j+1][i] = 0;\n			a[i][i + j+1] = 0;\n		}\n	}\n		\n	for (int i = 0;i < m;i++) {		\n		for (int j = 0;j < m;j++) {			\n			cout << a[i][j] << \" \";\n		}\n		cout << endl;\n	}\n	}";
                        break;
                    case 92:
                        richTextBox1.Text = "Дана квадратная матрица порядка M. Обнулить элементы матрицы, лежащие одновременно выше главной диагонали и выше побочной диагонали. Условный оператор не использовать.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int a[255][255], m,max1,max2;\n	cin >> m;\n		\n	for (int i = 0;i < m;i++) {		\n		for (int j = 0;j < m;j++) {			\n			cin >> a[i][j];\n		}\n	}\n		\n	for (int i = 0;i < m;i++) {		\n		for (int j = m-1;j >= 0;j--) {			\n			a[i][i+1+j] = 0;\n			a[i][m-2-i-j] = 0;\n		}\n	}\n		\n	for (int i = 0;i < m;i++) {		\n		for (int j = 0;j < m;j++) {			\n			cout << a[i][j] << \" \";\n		}\n		cout << endl;\n	}\n		}";
                        break;
                    case 93:
                        richTextBox1.Text = "Дана квадратная матрица порядка M. Обнулить элементы матрицы, лежащие одновременно выше главной диагонали и ниже побочной диагонали. Условный оператор не использовать.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int a[255][255], m,max1,max2;\n	cin >> m;\n		\n	for (int i = 0;i < m;i++) {		\n		for (int j = 0;j < m;j++) {			\n			cin >> a[i][j];\n		}\n	}\n		\n	for (int i = 0;i < m;i++) {		\n		for (int j = 0;j < m;j++) {			\n			a[i][i+j+1] = 0;\n			a[i][m - 1 - i + j] = 0;\n		}\n	}\n		\n	for (int i = 0;i < m;i++) {		\n		for (int j = 0;j < m;j++) {			\n			cout << a[i][j] << \" \";\n		}\n		cout << endl;\n	}\n}";
                        break;
                    case 94:
                        richTextBox1.Text = "Дана квадратная матрица порядка M. Обнулить элементы матрицы, лежащие одновременно ниже главной диагонали (включая эту диагональ) и выше побочной диагонали (также включая эту диагональ). Условный оператор не использовать.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int a[255][255], m,max1,max2;\n	cin >> m;\n		\n	for (int i = 0;i < m;i++) {		\n		for (int j = 0;j < m;j++) {			\n			cin >> a[i][j];\n		}\n	}\n		\n	for (int i = 0;i < m;i++) {		\n		for (int j = 0;j < m;j++) {			\n			a[i+j][i] = 0;\n			a[i-j][m - 1 - i] = 0;\n		}\n	}\n		\n	for (int i = 0;i < m;i++) {		\n		for (int j = 0;j < m;j++) {			\n			cout << a[i][j] << \" \";\n		}\n		cout << endl;\n	}\n		}";
                        break;
                    case 95:
                        richTextBox1.Text = "Дана квадратная матрица порядка M. Обнулить элементы матрицы, лежащие одновременно ниже главной диагонали (включая эту диагональ) и ниже побочной диагонали (также включая эту диагональ). Условный оператор не использовать.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int m, a[255][255];\n	cin >> m;\n	for (int i = 0;i < m; i++) {		\n		for (int j = 0; j < m; j++) {			\n			cin >> a[i][j];\n		}\n	}\n		\n	for (int i = 0; i < m; i++) {		\n		for (int j = 0; j < m; j++) {			\n			a[i][i] = 0;\n			a[i + j][i] = 0;\n			a[i][m - i - 1] = 0;\n			a[i + j][m - i - 1] = 0;\n		}\n	}\n		\n	for (int i = 0;i < m; i++) {		\n		for (int j = 0; j < m; j++) {			\n			cout << a[i][j] << \" \";\n		}\n		cout << endl;\n	}\n}";
                        break;
                    case 96:
                        richTextBox1.Text = "Дана квадратная матрица A порядка M. Зеркально отразить ее элементы относительно главной диагонали (при этом элементы главной диагонали останутся на прежнем месте, элемент A1,2 поменяется местами с A2,1, элемент A1,3 — с A3,1 и т. д.). Вспомогательную матрицу не использовать.";
                        richTextBox2.Text = "#include <iostream>\n#include <algorithm>\nusing namespace std;\n\nint main() {	\n	int m, a[255][255], temp[255][255], tempp[255][255];\n	cin >> m;\n	for (int i = 0; i < m; i++) {		\n		for (int j = 0; j < m;j++) {			\n			cin >> a[i][j];\n			temp[i][j] = a[i][j];\n		}\n	}\n		\n	for (int i = 0; i < m; i++) {		\n		for (int j = 0; j < m;j++) {			\n			a[i][j] = temp[j][i];\n				\n		}\n	}\n	for (int i = 0; i < m;i++)\n		a[i][m - i - 1] = temp[i][m - i - 1];\n		\n	cout << endl;\n	for (int i = 0; i < m;i++) {		\n		for (int j = 0; j < m;j++) {			\n			cout << a[i][j] << \" \";\n		}\n		cout << endl;\n	}\n}";
                        break;
                    case 97:
                        richTextBox1.Text = "Дана квадратная матрица A порядка M. Зеркально отразить ее элементы относительно побочной диагонали. (при этом элементы побочной диагонали останутся на прежнем месте, элемент A1,1 поменяется местами с AM,M, элемент A1,2 — с AM-1,M и т. д.). Вспомогательную матрицу не использовать.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nvoid swap(int x, int y) {	\n	if (x != y) {		\n		x += y;\n		y = x - y;\n		x -= y;\n	}\n}\n\nint main() {			\n	int a[255][255], m;\n	cin >> m;\n	for (int i = 0; i < m; i++) {		\n		for (int j = 0; j < m; j++) {			\n			cin >> a[i][j];\n		}\n	}\n	cout << endl;\n	for (int j = 0;j < m;j++) {		\n		for (int i = 0; i < m; i++) {			\n			swap(a[i][j], a[m - j + 1][m - i + 1]);\n		}\n	}\n		\n	for (int i = 0; i < m; i++) {		\n		for (int j = 0; j < m; j++) {			\n			cout << a[i][j] << \" \";\n		}\n		cout << endl;\n	}\n}";
                        break;
                    case 98:
                        richTextBox1.Text = "Дана квадратная матрица A порядка M. Повернуть ее на угол 180º (при этом элемент A1,1 поменяется местами с AM,M, элемент A1,2 — с AM,M-1 и т. д.). Вспомогательную матрицу не использовать.";
                        richTextBox2.Text = "#include <iostream>\n#include <algorithm>\nusing namespace std;\n\nint main() {	\n	int a[255][255], m;\n	cin >> m;\n		\n	for (int i = 0; i < m; i++) {		\n		for (int j = 0; j < m;j++) {			\n			cin >> a[i][j];\n		}\n	}\n		\n	for (int i = 0; i < m/2;i++) {		\n		for (int j = 0; j < m;j++) {			\n			swap(a[i][j], a[m-1-i][m-1 - j]);\n		}\n	}\n		\n	for (int i = 0; i < m; i++) {		\n		for (int j = 0; j < m;j++) {			\n			cout << a[i][j] << \" \";\n		}\n		cout << endl;\n	}\n}";
                        break;
                    case 99:
                        richTextBox1.Text = "Дана квадратная матрица A порядка M. Повернуть ее на угол 90º в положительном направлении, то есть против часовой стрелки (при этом элемент A1,1 перейдет в AM,1, элемент AM,1 — в AM,M и т. д.). Вспомогательную матрицу не использовать.";
                        richTextBox2.Text = "#include <iostream>\n#include <algorithm>\n#include <vector>\n#include <iomanip>\nusing namespace std;\n\n// На месте повернуть его на 90 градусов против часовой стрелки\nvoid rotate(vector<vector<int>>& mat)\n{ \n    // Матрица `N × N`\n    int N = mat.size();\n    \n    // базовый вариант\n    if (N == 0) {        \n        return;\n    }\n\n    // Транспонировать матрицу\n    for (int i = 0; i < N; i++)\n    { \n        for (int j = 0; j < i; j++) {            \n            swap(mat[i][j], mat[j][i]);\n        }\n    }\n        \n    // поменять местами строки\n    for (int i = 0; i < N / 2; i++)\n    { \n        for (int j = 0; j < N; j++) {            \n            swap(mat[i][j], mat[N - i - 1][j]);\n        }\n    }\n}\n\n// Функция для печати матрицы\nvoid printMatrix(vector<vector<int>> const& mat)\n{ \n    for (auto& row : mat) {        \n        for (auto& i : row) {            \n            cout << setw(3) << i;\n        }\n        cout << endl;\n    }\n    cout << endl;\n}\n\nint main()\n{ \n    vector<vector<int>> mat = \n    { \n        { 1, 1, 1, 1 }, \n        { 2, 2, 2, 2 }, \n        { 3, 3, 3, 3 }, \n        { 4, 4, 4, 4 }\n    };\n            \n    rotate(mat);\n    printMatrix(mat);\n                \n    return 0;\n}";
                        break;
                    case 100:
                        richTextBox1.Text = "Дана квадратная матрица A порядка M. Повернуть ее на угол 90º в отрицательном направлении, то есть по часовой стрелке (при этом элемент A1,1 перейдет в A1,M, элемент A1,M — в AM,M и т. д.). Вспомогательную матрицу не использовать.";
                        richTextBox2.Text = "#include <iostream>\n\nusing namespace std;\n\nint main()\n{ \n    int n, a[255][255];\n    cin >> n;\n    for (int i = 0; i < n; i++)\n    { \n        for (int j = 0; j < n; j++)\n        { \n            cin >> a[i][j];\n        }\n    }\n    cout << endl;\n    for (int i = 0; i < n; i++)\n    { \n        for (int j = 0; j < n; j++)\n        { \n            cout << a[n - j - 1][i] << \" \";\n        }\n        cout << endl;\n    }\n        \n}";
                        break;
                    default:
                        richTextBox1.Text = "";
                        richTextBox2.Text = "";
                        break;
                }
            }


            if (comboBox1.SelectedIndex == 7)   // Задачи с Array(1-140)
            {
                switch (comboBox2.SelectedIndex + 1)
                {
                    case 1:
                        richTextBox1.Text = "Дано целое число N > 0. Сформировать и вывести целочисленный массив размера N, содержащий N первых положительных нечетных чисел: 1, 3, 5, … .";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{\n    int n;\n    cin >> n;\n    int a[255];\n    for (int i = 0; i < n; ++i)\n        cin >> a[i];\n    for (int i = 0; i < n; ++i)\n        cout << a[i] << \" \";\n    for (int j = 0; j < n / 2; ++j)\n        cout << a[j] << \" \";\n        \n    return 0;\n}";
                        break;
                    case 2:
                        richTextBox1.Text = "Дано целое число N > 0. Сформировать и вывести целочисленный массив размера N, содержащий степени двойки от первой до N-й: 2, 4, 8, 16, … .";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n	int n;\n	cin >> n;\n	int a[255];	for (int i = 1; i < n; ++i)\n	{ \n		a[0] = 2;\n		a[i] = a[i - 1] * 2;\n	}\n	for (int i = 0; i < n; i++)\n	{ \n		cout << endl << \"array[\" << i << \"]=\" << a[i];\n	}\n	cout << endl << a[10];\n}";
                        break;
                    case 3:
                        richTextBox1.Text = "Дано целое число N > 1, а также первый член A и разность D арифметической прогрессии. Сформировать и вывести массив размера N, содержащий N первых членов данной прогрессии:";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main() {	\n	float a[255];\n	float n, d;\n	cin >> n;\n	cin >> a[0];\n	cin >> d;\n	for (int i = 1;i < n;i++) a[i] = a[0] + (i)*d;\n	for (int i = 0;i < n;i++) cout << a[i] << \" \";\n	return 0;\n}";
                        break;
                    case 4:
                        richTextBox1.Text = "Дано целое число N> 1, а также первый член A и знаменатель D геометрической прогрессии. Сформировать и вывести массив размера N, содержащий N первых членов данной прогрессии:";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main()\n{ \n	int n, a, d;\n	cin >> n >> a >> d;\n	int arr[]{ n };\n	\n	for (int i = 0; i <= n; i++)\n	{ \n		arr[i] = a * pow(d, i);\n		cout << arr[i] << \" \";\n	}\n}";
                        break;
                    case 5:
                        richTextBox1.Text = "Дано целое число N > 2. Сформировать и вывести целочисленный массив размера N, содержащий N первых элементов последовательности чисел Фибоначчи";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main()\n{ \n	int a[255], n, i;\n	cin >> n;\n	\n	a[0] = 1;\n	a[1] = 1;\n	for (i = 2;i < n;i++) a[i] = a[i - 2] + a[i - 1];\n		\n	for (i = 0;i < n;i++)\n		cout << i << \": \" << a[i] << endl;\n}";
                        break;
                    case 6:
                        richTextBox1.Text = "Даны целые числа N > 2, A и B. Сформировать и вывести целочисленный массив размера N, первый элемент которого равен A, второй равен B, а каждый последующий элемент равен сумме всех предыдущих.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main()\n{ \n	int a[255], n, i;\n	cin >> n;\n	cin >> a[0];\n	cin >> a[1];\n	for (i = 2;i < n;i++) a[i] = a[i - 2] + a[i - 1];\n		\n	for (i = 0;i < n;i++)\n		cout << i << \": \" << a[i] << endl;\n}";
                        break;
                    case 7:
                        richTextBox1.Text = "Дан массив размера N. Вывести его элементы в обратном порядке.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int a[10];\n    int n, i;\n    cout << \"N:\";\n    cin >> n;\n    for (i = 0; i < n; ++i) {        \n        cout << \"a[\" << i << \"]:\";\n        cin >> a[i];\n    }\n    for (i = n - 1; i >= 0; --i)\n        cout << \"a[\" << i << \"]=\" << a[i] << endl;\n    return 0;\n}";
                        break;
                    case 8:
                        richTextBox1.Text = "Дан целочисленный массив размера N. Вывести все содержащиеся в данном массиве нечетные числа в порядке возрастания их индексов, а также их количество K.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{\n    int n, k = 0;\n    cin >> n;\n    int arr[100];\n    for (int i = 0; i < n;i++) {        \n        cin >> arr[i];\n    };\n        \n    for (int i = 1; i <= n; i++)\n    { \n    if (arr[i] % 2 == 1)\n    { \n        cout << endl << arr[i];\n            k++;\n    }\n    else\n        continue;\n    }\n    cout << endl << \" k = \" << k;\n}  ";
                        break;
                    case 9:
                        richTextBox1.Text = "Дан целочисленный массив размера N. Вывести все содержащиеся в данном массиве четные числа в порядке убывания их индексов, а также их количество K.";
                        richTextBox2.Text = "";
                        break;
                    case 10:
                        richTextBox1.Text = "Дан целочисленный массив размера N. Вывести вначале все содержащиеся в данном массиве четные числа в порядке возрастания их индексов, а затем − все нечетные числа в порядке убывания их индексов.";
                        richTextBox2.Text = "";
                        break;
                    case 11:
                        richTextBox1.Text = "Дан массив A размера N и целое число K (1 ≤ K ≤ N). Вывести элементы массива с порядковыми номерами, кратными K: AK, A2*K, A3*K, … . Условный оператор не использовать.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int n, k;\n    cin >> n >> k;\n    int a[255];\n    for (int i = 0; i < n; ++i) {        \n        cin >> a[i];\n    }\n    for (int i = k; i < n; i += k)\n        cout << a[i] << \" \";\n    return 0;\n}";
                        break;
                    case 12:
                        richTextBox1.Text = "Дан массив A размера N (N − четное число). Вывести его элементы с четными номерами в порядке возрастания номеров: A2, A4, A6, …, AN. Условный оператор не использовать.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int n;\n    cin >> n;\n    int a[255];\n    for (int i = 0; i < n; ++i) {        \n        cin >> a[i];\n    }\n    for (int i = 1; i < n; i += 2) \n        cout << a[i] << \" \";\n    return 0;\n}";
                        break;
                    case 13:
                        richTextBox1.Text = "Дан массив A размера N (N − нечетное число). Вывести его элементы с нечетными номерами в порядке убывания номеров: AN, AN-2, AN-4, …, A1. Условный оператор не использовать.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int n;\n    cin >> n;\n    int a[255];\n    for (int i = 0; i < n; ++i) {        \n        cin >> a[i];\n    }\n    for (int i = n - 1; i >= 0; i -= 2)\n        cout << a[i] << \" \";\n    return 0;\n}";
                        break;
                    case 14:
                        richTextBox1.Text = "Дан массив A размера N. Вывести вначале его элементы с четными номерами (в порядке возрастания номеров), а затем − элементы с нечетными номерами (также в порядке возрастания номеров): A2, A4, A6, …, A1, A3, A5, … . Условный оператор не использовать.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n	float a[10];\n	int n;\n	cin >> n;\n	for (int i = 0; i < n;i++){		\n		cin >> a[i];\n	}\nfor (int i = 1; i < n; i += 2)\n{ \n	cout << a[i] << endl;\n}\nfor (int i = 0; i < n; i += 2)\n{ \n	cout << a[i] << endl;\n}\nreturn 0;\n}";
                        break;
                    case 15:
                        richTextBox1.Text = "Дан массив A размера N. Вывести вначале его элементы с нечетными номерами в порядке возрастания номеров, а затем − элементы с четными номерами в порядке убывания номеров. A1, A3, A5, …, A6, A4, A2. Условный оператор не использовать.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int N[20]{ 1,2,3,4,5,6,7,8,9,10,11,12,13,14,15,16,17,18,19,20 }, a = 20;\n	for (int i = 0; i < a; i++) {		\n		if (i == 0 && i == 1) {			\n			continue;\n		}\n		if (i % 2 == 1) {			\n			continue;\n		}\n		cout << N[i] << \" \";\n	}\n		\n	for (int i = a; i > 0; i--) {		\n		if (i % 2 == 0) {			\n			continue;\n		}\n		switch (a) {			\n		case 0:\n			continue;\n			break;\n		case 1:\n			cout << N[i];\n			break;\n		}\n		cout << N[i] << \" \";\n	}\n}";
                        break;
                    case 16:
                        richTextBox1.Text = "Дан массив A размера N. Вывести его элементы в следующем порядке: A1, AN, A2, AN-1, A3, AN-2, … .";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\n\nint main() {	\n	int n, N, a;\n	cin >> n, N;\n	int A[]{ n };\n	for (int i = 0; i < n; i++) {		\n			\n		if (A[i] % 2 == 0) {			\n			for (int i = N; i > 0; i--) {				\n				cout << A[N];\n			}\n		}\n		else {			\n			cout << A[n];\n		}\n			\n	}\n}";
                        break;
                    case 17:
                        richTextBox1.Text = "Дан массив A размера N. Вывести его элементы в следующем порядке: A1, A2, AN, AN-1, A3, A4, AN-2, AN-3, … .";
                        richTextBox2.Text = "";
                        break;
                    case 18:
                        richTextBox1.Text = "Дан массив A ненулевых целых чисел размера 10. Вывести значение первого из тех его элементов AK, которые удовлетворяют неравенству AK < A10. Если таких элементов нет, то вывести 0.";
                        richTextBox2.Text = "#include <iostream>\n\nusing namespace std;\n\nint main()\n{ \n    int i, a[10], k;\n    for (i = 0; i < 10; i++)\n    { \n        cout << \"a[\" << i << \"]: \";\n        cin >> a[i];\n    }\n    for (i = 0; i < 9; i++)\n    { \n        if (a[i] < a[9]) { cout << a[i] << endl; }\n        if (a[8] > a[9]) { k = 0; cout << k << endl; }\n    }\n    return 0;\n}";
                        break;
                    case 19:
                        richTextBox1.Text = "Дан целочисленный массив A размера 10. Вывести порядковый номер последнего из тех его элементов AK, которые удовлетворяют двойному неравенству A1 < AK < A10. Если таких элементов нет, то вывести 0.";
                        richTextBox2.Text = "#include <iostream>\n\nusing namespace std;\n\nint main()\n{ \n    int a[10];\n    int k;\n    for (k = 0; k < 10; k++) {        \n        cout << \"a[\" << k << \"]:\";\n        cin >> a[k];\n    }\n    k = 9;\n    while (((a[0] >= a[k]) || (a[k] >= a[9])) && (k > 0)) {        \n        --k;\n    }\n    if (k == 0) cout << k;\n    else cout << a[k];\n    return 0;\n}";
                        break;
                    case 20:
                        richTextBox1.Text = "Дан массив размера N и целые числа K и L (1 ≤ K ≤ L ≤ N). Найти сумму элементов массива с номерами от K до L включительно.";
                        richTextBox2.Text = "#include <iostream>\n\nusing namespace std;\n\nint main()\n{ \n    cout << \"N = 10 || K < 10 || L < 10\" << endl;\n    const int n = 10;\n    int K, L;\n    cin >> K >> L;\n    int arr[n];\n    \n    for (int i = 0; i < n; i++) {       \n        arr[i] = i;\n        for (int j = K; j <= L;j++) {            \n            if (j != i) {                \n                continue;\n            }\n            cout << arr[i] << \" \";\n        }\n            \n    }\n    return 0;\n}";
                        break;
                    case 21:
                        richTextBox1.Text = "Дан массив размера N и целые числа K и L (1 ≤ K ≤ L ≤ N). Найти среднее арифметическое элементов массива с номерами от K до L включительно.";
                        richTextBox2.Text = "#include <iostream>\n\nusing namespace std;\n\nint main()\n{ \n    setlocale(LC_ALL, \"ru\");\n    const int n = 10;\n    int K, L, a = 0, b;\n    cin >> K >> L;\n    int arr[n];\n    \n    for (int i = 0; i < n; i++) {        \n        arr[i] = i;\n        for (int j = K; j <= L;j++) {            \n            if (j != i) {                \n                continue;\n            }\n            cout << arr[i] << \" \";\n            a += i;\n            b = a / (L - K + 1);\n        }\n            \n    }\n    cout << endl;\n    cout << \"Среднее арифметическое число: \" << b << endl;\n    return 0;\n}";
                        break;
                    case 22:
                        richTextBox1.Text = "Дан массив размера N и целые числа K и L (1 < K ≤ L ≤ N). Найти сумму всех элементов массива, кроме элементов с номерами от K до L включительно.";
                        richTextBox2.Text = "#include <iostream>\n\nusing namespace std;\n\nint main()\n{ \n    int b = 10;\n    int a[b];\n    int n, k, l;\n    \n    cout << \"N: \";\n    cin >> n;\n    cout << \"K: \";\n    cin >> k;\n    cout << \"L: \";\n    cin >> l;\n   \n    int i;\n    for (i = 0; i < n; ++i) {        \n        cout << \"a[\" << i + 1 << \"] :\";\n        cin >> a[i];\n    }\n      \n    int sum = 0;\n    for (i = 0; i < n; ++i) {        \n        for (i = l; i < k; ++i) {            \n            a[i] = i;\n            cout << a[i] << \" \";\n        }\n    }\n}";
                        break;
                    case 23:
                        richTextBox1.Text = "Дан массив размера N и целые числа K и L (1 < K ≤ L ≤ N). Найти среднее арифметическое всех элементов массива, кроме элементов с номерами от K до L включительно.";
                        richTextBox2.Text = "#include <iostream>\n\nusing namespace std;\n\nint main()\n{ \n    int a[10];\n    int n, k, l;\n    \n    cout << \"N: \";\n    cin >> n;\n    cout << \"K: \";\n    cin >> k;\n    cout << \"L: \";\n    cin >> l;\n    \n    int i;\n    for (i = 0; i < n; ++i) {        \n        cout << \"a[\" << i + 1 << \"] :\";\n        cin >> a[i];\n    }\n        \n    int sum = 0;\n    for (i = 0; i < k - 1; ++i) sum += a[i];\n    for (i = l; i < n; ++i) sum += a[i];\n        \n    cout << (float)sum / (float)(k - 1 + (n - l));\n       \n    return 0;\n}";
                        break;
                    case 24:
                        richTextBox1.Text = "Дан целочисленный массив размера N, не содержащий одинаковых чисел. Проверить, образуют ли его элементы арифметическую прогрессию (см. задание Array3). Если образуют, то вывести разность прогрессии, если нет − вывести 0.";
                        richTextBox2.Text = "#include <iostream> \n#include <cstdlib> \nusing namespace std;\nint main(int argc, char* argv[])\n{ \n    setlocale(LC_ALL, \"Russian\");\n    int N;\n    cout << \"N = \";\n    cin >> N;\n    \n    int* arr = new int[N];\n    for (int i = 0; i < N;i++)\n    { \n        cout << \"arr[\" << i + 1 << \"]: \";\n        cin >> arr[i];\n    }\n    int delta = arr[1] - arr[0];\n    for (int i = 1; i < N - 1; i++)\n    { \n        if (arr[i + 1] - arr[i] != delta)\n        { \n            std::cout << \"0\";\n            exit(1);\n        }\n    }\n        \n    cout << delta << endl;\n    delete[] arr;\n    return 0;\n}";
                        break;
                    case 25:
                        richTextBox1.Text = "Дан массив ненулевых целых чисел размера N. Проверить, образуют ли его элементы геометрическую прогрессию (см. задание Array4). Если образуют, то вывести знаменатель прогрессии, если нет − вывести 0.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int N;\n    cout << \"N: \";\n    cin >> N;\n    \n    int* Array = new int[N];\n    \n    cout << \"array: \";\n    for (int = 0 i <= 0; i++)\n    { \n        cin >> Ar[i];\n        if (Array[i] == 0)\n            Array[i]++;\n    }\n        \n    float D = (Array[1] / Array[0]), A = Array[0];\n    for (int i = 0; i < N; i++)\n        if (Array[i] != A * pow(D, i))\n        { \n            cout << 0 << endl;\n        }\n    cout << D << endl;\n}";
                        break;
                    case 26:
                        richTextBox1.Text = "Дан целочисленный массив размера N. Проверить, чередуются ли в нем четные и нечетные числа. Если чередуются, то вывести 0, если нет, то вывести порядковый номер первого элемента, нарушающего закономерность.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int N;\n    cout << \"N: \";\n    cin >> N;\n    int* A = new int[N];\n    cout << \"array:\";\n    \n    for (int i = 0; i < N; i++)\n        cin >> A[i];\n        \n    for (int i = 0; i < N - 1; i++)\n        \n        if ((A[i] + A[i + 1]) % 2 == 0)\n        {            \n            cout << (i + 1) + 1 << endl;\n            \n        }\n}";
                        break;
                    case 27:
                        richTextBox1.Text = "Дан массив ненулевых целых чисел размера N. Проверить, чередуются ли в нем положительные и отрицательные числа. Если чередуются, то вывести 0, если нет, то вывести порядковый номер первого элемента, нарушающего закономерность.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int N;\n    cout << \"N: \";\n    cin >> N;\n    \n    int* A = new int[N];\n    \n    cout << \"array:\";\n    \n    for (int i = 0; i < N; i++)\n    { \n        cin >> A[i];\n        if (A[i] == 0) A[i]++;\n    }\n        \n    for (int i = 0; i < N - 1; i++)\n        if ((A[i] * A[i + 1]) > 0)\n        { \n            cout << (i + 1) + 1 << endl;\n            \n        }\n    cout << \"0\";\n    return 0;\n}";
                        break;
                    case 28:
                        richTextBox1.Text = "Дан массив A размера N. Найти минимальный элемент из его элементов с четными номерами: A2, A4, A6, … .";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int N;\n    cout << \"N: \";\n    cin >> N;\n    \n    float* A = new float[N];\n    \n    cout << \"array: : \";\n    \n    for (int i = 0; i < N; i++)\n        cin >> A[i];\n        \n    float min = A[1];\n    for (int i = 3; i < N; i++, i++)\n        if (A[i] < min)\n            \n            min = A[i];\n    cout << \"Min = \" << min << endl;\n}";
                        break;
                    case 29:
                        richTextBox1.Text = "Дан массив A размера N. Найти максимальный элемент из его элементов с нечетными номерами: A1, A3, A5, … .";
                        richTextBox2.Text = "#include <iostream>\n\nusing namespace std;\n\nint main() {    \n    int a[10];\n    int n;\n    \n    cout << \"N: \";\n    cin >> n;\n        \n    int i;\n    for (i = 0; i < n; ++i) {        \n        cout << \"a[\" << i + 1 << \"]: \";\n        cin >> a[i];\n    }\n        \n    int max = a[0];\n    for (i = 0; i < n; i += 2) {        \n        if (a[i] > max) max = a[i];\n    }\n        \n    cout << max << endl;\n    return 0;\n}";
                        break;
                    case 30:
                        richTextBox1.Text = "Дан массив размера N. Найти номера тех элементов массива, которые больше своего правого соседа, и количество таких элементов. Найденные номера выводить в порядке их возрастания.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int N, num(0);\n    cout << \"N: \";\n    cin >> N;\n    \n    float* A = new float[N];\n    \n    cout << \"array:\";\n    \n    for (int i = 0; i < N; i++)\n        cin >> A[i];\n    for (int i = 0; i < N - 1; i++)\n        if (A[i] > A[i + 1])\n        { \n            cout << i + 1 << \" \";\n            num++;\n        }\n            \n    cout << \"Sum: \" << num << endl;\n}";
                        break;
                    case 31:
                        richTextBox1.Text = "Дан массив размера N. Найти номера тех элементов массива, которые больше своего левого соседа, и количество таких элементов. Найденные номера выводить в порядке их убывания.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int N, num(0);\n    cout << \"N: \";\n    cin >> N;\n    \n    float* A = new float[N];\n    cout << \"array:\";\n    for (int i = 0; i < N; i++)\n        cin >> A[i];\n        \n    for (int i = N - 1; i > 0; i--)\n        if (A[i] > A[i - 1])\n        { \n            cout << i + 1 << \" \";\n            num++;\n        }\n    cout << \"Sum\" << num << endl;\n    return 0;\n}";
                        break;
                    case 32:
                        richTextBox1.Text = "Дан массив размера N. Найти номер его первого локального минимума (локальный минимум − это элемент, который меньше любого из своих соседей).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int N;\n    cout << \"N: \";\n    cin >> N;\n    \n    float* A = new float[N];\n    cout << \"array: \";\n    \n    for (int i = 0; i < N; i++)\n        cin >> A[i];\n        \n    for (int i = N - 2; i > 0; i--)\n        if (A[i] > A[i - 1] && A[i] > A[i + 1])\n        { \n            cout << i + 1 << endl;\n            \n        }\n    cout << \"There is no local maximum\" << endl;\n    return 0;\n}";
                        break;
                    case 33:
                        richTextBox1.Text = "Дан массив размера N. Найти номер его последнего локального максимума (локальный максимум − это элемент, который больше любого из своих соседей).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n\n    int N;\n    cout << \"N: \";\n    cin >> N;\n    \n    float* A = new float[N];\n    cout << \"array: \";\n    \n    for (int i = 0; i < N; i++)\n        cin >> A[i];\n        \n    for (int i = N - 2; i > 0; i--)\n        if (A[i] > A[i - 1] && A[i] > A[i + 1])\n        { \n            cout << i + 1 << endl;\n            \n        }\n    cout << \"there is no local maximum\" << endl;\n            \n    return 0;\n}";
                        break;
                    case 34:
                        richTextBox1.Text = "Дан массив размера N. Найти максимальный из его локальных минимумов (определение локального минимума дано в задании Array32).";
                        richTextBox2.Text = "";
                        break;
                    case 35:
                        richTextBox1.Text = "Дан массив размера N. Найти минимальный из его локальных максимумов (определение локального максимума дано в задании Array33).";
                        richTextBox2.Text = "";
                        break;
                    case 36:
                        richTextBox1.Text = "Дан массив размера N. Найти максимальный из его элементов, не являющихся ни локальным минимумом, ни локальным максимумом (определения локального минимума и локального максимума даны в заданиях Array32 и Array33). Если таких элементов в массиве нет, то вывести 0.";
                        richTextBox2.Text = "";
                        break;
                    case 37:
                        richTextBox1.Text = "Дан массив размера N. Найти количество участков, на которых его элементы монотонно возрастают.";
                        richTextBox2.Text = "";
                        break;
                    case 38:
                        richTextBox1.Text = "Дан массив размера N. Найти количество участков, на которых его элементы монотонно убывают.";
                        richTextBox2.Text = "";
                        break;
                    case 39:
                        richTextBox1.Text = "Дан массив размера N. Найти количество его промежутков монотонности (то есть участков, на которых его элементы возрастают или убывают).";
                        richTextBox2.Text = "";
                        break;
                    case 40:
                        richTextBox1.Text = "Дано число R и массив A размера N. Найти элемент массива, который наиболее близок к числу R (то есть такой элемент AK, для которого величина |AK — R| является минимальной).";
                        richTextBox2.Text = "";
                        break;
                    case 41:
                        richTextBox1.Text = "Дан массив размера N. Найти два соседних элемента, сумма которых максимальна, и вывести эти элементы в порядке возрастания их индексов.";
                        richTextBox2.Text = "";
                        break;
                    case 42:
                        richTextBox1.Text = "Дано число R и массив размера N. Найти два соседних элемента массива, сумма которых наиболее близка к числу R, и вывести эти элементы в порядке возрастания их индексов (определение наиболее близких чисел дано в задании Array40).";
                        richTextBox2.Text = "";
                        break;
                    case 43:
                        richTextBox1.Text = "Дан целочисленный массив размера N, все элементы которого упорядочены (по возрастанию или по убыванию). Найти количество различных элементов в данном массиве.";
                        richTextBox2.Text = "";
                        break;
                    case 44:
                        richTextBox1.Text = "Дан целочисленный массив размера N, содержащий ровно два одинаковых элемента. Найти номера одинаковых элементов и вывести эти номера в порядке возрастания.";
                        richTextBox2.Text = "";
                        break;
                    case 45:
                        richTextBox1.Text = "Дан массив размера N. Найти номера двух ближайших элементов из этого массива (то есть элементов с наименьшим модулем разности) и вывести эти номера в порядке возрастания.";
                        richTextBox2.Text = "";
                        break;
                    case 46:
                        richTextBox1.Text = "Дано число R и массив размера N. Найти два различных элемента массива, сумма которых наиболее близка к числу R, и вывести эти элементы в порядке возрастания их индексов (определение наиболее близких чисел дано в задании Array40).";
                        richTextBox2.Text = "";
                        break;
                    case 47:
                        richTextBox1.Text = "Дан целочисленный массив размера N. Найти количество различных элементов в данном массиве.";
                        richTextBox2.Text = "";
                        break;
                    case 48:
                        richTextBox1.Text = "Дан целочисленный массив размера N. Найти максимальное количество его одинаковых элементов.";
                        richTextBox2.Text = "";
                        break;
                    case 49:
                        richTextBox1.Text = "Дан целочисленный массив размера N. Если он является перестановкой, то есть содержит все числа от 1 до N, то вывести 0; в противном случае вывести номер первого недопустимого элемента.";
                        richTextBox2.Text = "";
                        break;
                    case 50:
                        richTextBox1.Text = "Дан целочисленный массив A размера N, являющийся перестановкой (определение перестановки дано в задании Array49). Найти количество инверсий в данной перестановке, то есть таких пар элементов AI и AJ, в которых большее число находится слева от меньшего: AI > AJ при I < J.";
                        richTextBox2.Text = "";
                        break;
                    case 51:
                        richTextBox1.Text = "Даны массивы A и B одинакового размера N. Поменять местами их содержимое и вывести вначале элементы преобразованного массива A, а затем − элементы преобразованного массива B.";
                        richTextBox2.Text = "";
                        break;
                    case 52:
                        richTextBox1.Text = "Дан массив A размера N. Сформировать новый массив B того же размера, элементы которого определяются следующим образом:";
                        richTextBox2.Text = "";
                        break;
                    case 53:
                        richTextBox1.Text = "Даны два массива A и B одинакового размера N. Сформировать новый массив C того же размера, каждый элемент которого равен максимальному из элементов массивов A и B с тем же индексом.";
                        richTextBox2.Text = "";
                        break;
                    case 54:
                        richTextBox1.Text = "Дан целочисленный массив A размера N. Переписать в новый целочисленный массив B все четные числа из исходного массива (в том же порядке) и вывести размер полученного массива B и его содержимое.";
                        richTextBox2.Text = "";
                        break;
                    case 55:
                        richTextBox1.Text = "Дан целочисленный массив A размера N ≤ 15. Переписать в новый целочисленный массив B все элементы с нечетными порядковыми номерами (1, 3, …) и вывести размер полученного массива B и его содержимое. Условный оператор не использовать.";
                        richTextBox2.Text = "";
                        break;
                    case 56:
                        richTextBox1.Text = "Дан целочисленный массив A размера N ≤ 15. Переписать в новый целочисленный массив B все элементы с порядковыми номерами, кратными трем (3, 6, …), и вывести размер полученного массива B и его содержимое. Условный оператор не использовать.";
                        richTextBox2.Text = "";
                        break;
                    case 57:
                        richTextBox1.Text = "Дан целочисленный массив A размера N. Переписать в новый целочисленный массив B того же размера вначале все элементы исходного массива с четными номерами, а затем − с нечетными: A2, A4, A6, …, A1, A3, A5, … . Условный оператор не использовать.";
                        richTextBox2.Text = "";
                        break;
                    case 58:
                        richTextBox1.Text = "Дан массив A размера N. Сформировать новый массив B того же размера по следующему правилу: элемент BK равен сумме элементов массива A с номерами от 1 до K.";
                        richTextBox2.Text = "";
                        break;
                    case 59:
                        richTextBox1.Text = "Дан массив A размера N. Сформировать новый массив B того же размера по следующему правилу: элемент BK равен среднему арифметическому элементов массива A с номерами от 1 до K.";
                        richTextBox2.Text = "";
                        break;
                    case 60:
                        richTextBox1.Text = "Дан массив A размера N. Сформировать новый массив B того же размера по следующему правилу: элемент BK равен сумме элементов массива A с номерами от K до N.";
                        richTextBox2.Text = "";
                        break;
                    case 61:
                        richTextBox1.Text = "Дан массив A размера N. Сформировать новый массив B того же размера по следующему правилу: элемент BK равен среднему арифметическому элементов массива A с номерами от K до N.";
                        richTextBox2.Text = "";
                        break;
                    case 62:
                        richTextBox1.Text = "Дан массив A размера N. Сформировать два новых массива B и C: в массив B записать все положительные элементы массива A, в массив C − все отрицательные (сохраняя исходный порядок следования элементов). Вывести вначале размер и содержимое массива B, а затем − размер и содержимое массива C.";
                        richTextBox2.Text = "";
                        break;
                    case 63:
                        richTextBox1.Text = "Даны два массива A и B размера 5, элементы которых упорядочены по возрастанию. Объединить эти массивы так, чтобы результирующий массив C (размера 10) остался упорядоченным по возрастанию.";
                        richTextBox2.Text = "";
                        break;
                    case 64:
                        richTextBox1.Text = "Даны три целочисленных массива A, B и C размера NA, NB, NC соответственно, элементы которых упорядочены по убыванию. Объединить эти массивы так, чтобы результирующий целочисленный массив D (размера NA + NB + NC) остался упорядоченным по убыванию.";
                        richTextBox2.Text = "";
                        break;
                    case 65:
                        richTextBox1.Text = "Дан массив A размера N и целое число K 1 ≤ K ≤ N. Преобразовать массив, увеличив каждый его элемент на исходное значение элемента AK.";
                        richTextBox2.Text = "#include <iostream> \nusing namespace std;\nint main()\n{ \n    int n; cin >> n;\n    int a[n];\n    for (int i = 0; i < n; i++) cin >> a[i];\n    for (int i = 0; i < n; i++) {        \n        a[i] += a[i];\n    }\n    for (int i = 0; i < n; i++) cout << a[i] << \' \';\n    return 0;\n}";
                        break;
                    case 66:
                        richTextBox1.Text = "Дан целочисленный массив размера N. Увеличить все четные числа, содержащиеся в массиве, на исходное значение первого четного числа. Если четные числа в массиве отсутствуют, то оставить массив без изменений.";
                        richTextBox2.Text = "#include <iostream> \nusing namespace std;\nint main()\n{ \n    int n; cin >> n;\n    int a[n], even_number = 0, counter = 0;\n    for (int i = 0; i < n; i++) cin >> a[i];\n    for (int i = 0; i < n; i++) {        \n        if (a[i] % 2 == 0 && counter <= 0) {            \n            even_number = a[i];\n            counter++;\n        }\n        if (a[i] % 2 == 0) a[i] += even_number;\n    }\n    for (int i = 0; i < n; i++) cout << a[i] << \' \';\n    return 0;\n}";
                        break;
                    case 67:
                        richTextBox1.Text = "Дан целочисленный массив размера N. Увеличить все нечетные числа, содержащиеся в массиве, на исходное значение последнего нечетного числа. Если нечетные числа в массиве отсутствуют, то оставить массив без изменений.";
                        richTextBox2.Text = "#include <iostream> \nusing namespace std;\nint main()\n{ \n    int n; cin >> n;\n    int a[n], odd_number = 0, counter = 0;\n    for (int i = 0; i < n; i++) cin >> a[i];\n    for (int i = n - 1; i >= 0; i--) {        \n        if (a[i] % 2 == 1 && counter <= 0) {            \n            odd_number = a[i];\n            counter++;\n        }\n        if (a[i] % 2 == 1) a[i] += odd_number;\n    }\n    for (int i = 0; i < n; i++) cout << a[i] << \' \';\n    return 0;\n}";
                        break;
                    case 68:
                        richTextBox1.Text = "Дан массив размера N. Поменять местами его минимальный и максимальный элементы.";
                        richTextBox2.Text = "";
                        break;
                    case 69:
                        richTextBox1.Text = "Дан массив размера N (N − четное число). Поменять местами его первый элемент со вторым, третий − с четвертым и т. д.";
                        richTextBox2.Text = "";
                        break;
                    case 70:
                        richTextBox1.Text = "Дан массив размера N (N − четное число). Поменять местами первую и вторую половины массива.";
                        richTextBox2.Text = "";
                        break;
                    case 71:
                        richTextBox1.Text = "Дан массив размера N. Поменять порядок его элементов на обратный.";
                        richTextBox2.Text = "";
                        break;
                    case 72:
                        richTextBox1.Text = "Дан массив A размера N и целые числа K и L (1 ≤ K < L ≤ N). Переставить в обратном порядке элементы массива, расположенные между элементами AK и AL, включая эти элементы.";
                        richTextBox2.Text = "#include <iostream> \nusing namespace std;\nint main()\n{ \n    int n, k, l; cin >> n >> k >> l;\n    int a[n];\n    for (int i = 0; i < n; i++) cin >> a[i];\n    for (int i = k; i <= l / 2; i++) {        \n        swap(a[i], a[l - i - 1]);\n    }\n    for (int i = 0; i < n; i++) cout << a[i] << \' \';\n    return 0;\n}";
                        break;
                    case 73:
                        richTextBox1.Text = "Дан массив A размера N и целые числа K и L (1 ≤ K < L ≤ N). Переставить в обратном порядке элементы массива, расположенные между элементами AK и AL, не включая эти элементы.";
                        richTextBox2.Text = "";
                        break;
                    case 74:
                        richTextBox1.Text = "Дан массив размера N. Обнулить элементы массива, расположенные между его минимальным и максимальным элементами (не включая минимальный и максимальный элементы).";
                        richTextBox2.Text = "";
                        break;
                    case 75:
                        richTextBox1.Text = "Дан массив размера N. Переставить в обратном порядке элементы массива, расположенные между его минимальным и максимальным элементами, включая минимальный и максимальный элементы.";
                        richTextBox2.Text = "";
                        break;
                    case 76:
                        richTextBox1.Text = "Дан массив размера N. Обнулить все его локальные максимумы (то есть числа, большие своих соседей).";
                        richTextBox2.Text = "";
                        break;
                    case 77:
                        richTextBox1.Text = "Дан массив размера N. Возвести в квадрат все его локальные минимумы (то есть числа, меньшие своих соседей).";
                        richTextBox2.Text = "";
                        break;
                    case 78:
                        richTextBox1.Text = "Дан массив размера N. Заменить каждый элемент массива на среднее арифметическое этого элемента и его соседей.";
                        richTextBox2.Text = "";
                        break;
                    case 79:
                        richTextBox1.Text = "Дан массив размера N. Осуществить сдвиг элементов массива вправо на одну позицию (при этом A1 перейдет в A2, A2 − в A3, …, AN–1 − в AN, a исходное значение последнего элемента будет потеряно). Первый элемент полученного массива положить равным 0.";
                        richTextBox2.Text = "";
                        break;
                    case 80:
                        richTextBox1.Text = "Дан массив размера N. Осуществить сдвиг элементов массива влево на одну позицию (при этом AN перейдет в AN-1, AN-1 − в AN-2, …, A2 − в A1, a исходное значение первого элемента будет потеряно). Последний элемент полученного массива положить равным 0.";
                        richTextBox2.Text = "";
                        break;
                    case 81:
                        richTextBox1.Text = "Дан массив размера N и целое число K (1 ≤ K < N). Осуществить сдвиг элементов массива вправо на K позиций (при этом A1 перейдет в AK+1, A2 − в AK+2, …, AN-K − в AN, а исходное значение K последних элементов будет потеряно). Первые K элементов полученного массива положить равными 0.";
                        richTextBox2.Text = "";
                        break;
                    case 82:
                        richTextBox1.Text = "Дан массив размера N и целое число K (1 ≤ K < N). Осуществить сдвиг элементов массива влево на K позиций (при этом AN перейдет в AN-K, AN-1 − в AN-K-1, …, AK+1 − в A1, а исходное значение K первых элементов будет потеряно). Последние K элементов полученного массива положить равными 0.";
                        richTextBox2.Text = "";
                        break;
                    case 83:
                        richTextBox1.Text = "Дан массив размера N. Осуществить циклический сдвиг элементов массива вправо на одну позицию (при этом A1 перейдет в A2, A2 − в A3, …, AN − в A1).";
                        richTextBox2.Text = "";
                        break;
                    case 84:
                        richTextBox1.Text = "Дан массив размера N. Осуществить циклический сдвиг элементов массива влево на одну позицию (при этом AN перейдет в AN-1, AN-1 − в AN-2, …, A1 − в AN).";
                        richTextBox2.Text = "";
                        break;
                    case 85:
                        richTextBox1.Text = "Дан массив A размера N и целое число K (1 ≤ K ≤ 4, K < N). Осуществить циклический сдвиг элементов массива вправо на K позиций (при этом A1 перейдет в AK+1, A2 − в AK+2, …, AN − в AK). Допускается использовать вспомогательный массив из 4 элементов.";
                        richTextBox2.Text = "";
                        break;
                    case 86:
                        richTextBox1.Text = "Дан массив A размера N и целое число K (1 ≤ K ≤ 4, K < N). Осуществить циклический сдвиг элементов массива влево на K позиций (при этом AN перейдет в AN-K, AN-1 − в AN-K-1, …, A1 − в AN-K+1). Допускается использовать вспомогательный массив из 4 элементов.";
                        richTextBox2.Text = "";
                        break;
                    case 87:
                        richTextBox1.Text = "Дан массив размера N, все элементы которого, кроме первого, упорядочены по возрастанию. Сделать массив упорядоченным, переместив первый элемент на новую позицию.";
                        richTextBox2.Text = "";
                        break;
                    case 88:
                        richTextBox1.Text = "Дан массив размера N, все элементы которого, кроме последнего, упорядочены по возрастанию. Сделать массив упорядоченным, переместив последний элемент на новую позицию.";
                        richTextBox2.Text = "";
                        break;
                    case 89:
                        richTextBox1.Text = "Дан массив размера N, все элементы которого, кроме одного, упорядочены по убыванию. Сделать массив упорядоченным, переместив элемент, нарушающий упорядоченность, на новую позицию.";
                        richTextBox2.Text = "";
                        break;
                    case 90:
                        richTextBox1.Text = "Дан массив размера N и целое число K (1 ≤ K ≤ N). Удалить из массива элемент с порядковым номером K.";
                        richTextBox2.Text = "";
                        break;
                    case 91:
                        richTextBox1.Text = "Дан массив размера N и целые числа K и L (1 ≤ K < L ≤ N). Удалить из массива элементы с номерами от K до L включительно и вывести размер полученного массива и его содержимое.";
                        richTextBox2.Text = "";
                        break;
                    case 92:
                        richTextBox1.Text = "Дан целочисленный массив размера N. Удалить из массива все нечетные числа и вывести размер полученного массива и его содержимое.";
                        richTextBox2.Text = "";
                        break;
                    case 93:
                        richTextBox1.Text = "Дан целочисленный массив размера N >2. Удалить из массива все элементы с четными номерами (2, 4, …). Условный оператор не использовать.";
                        richTextBox2.Text = "";
                        break;
                    case 94:
                        richTextBox1.Text = "Дан целочисленный массив размера N > 2. Удалить из массива все элементы с нечетными номерами (1, 3, …). Условный оператор не использовать.";
                        richTextBox2.Text = "";
                        break;
                    case 95:
                        richTextBox1.Text = "Дан целочисленный массив размера N. Удалить из массива все соседние одинаковые элементы, оставив их первые вхождения.";
                        richTextBox2.Text = "";
                        break;
                    case 96:
                        richTextBox1.Text = "Дан целочисленный массив размера N. Удалить из массива все одинаковые элементы, оставив их первые вхождения.";
                        richTextBox2.Text = "";
                        break;
                    case 97:
                        richTextBox1.Text = "Дан целочисленный массив размера N. Удалить из массива все одинаковые элементы, оставив их последние вхождения.";
                        richTextBox2.Text = "";
                        break;
                    case 98:
                        richTextBox1.Text = "Дан целочисленный массив размера N. Удалить из массива все элементы, встречающиеся менее трех раз, и вывести размер полученного массива и его содержимое.";
                        richTextBox2.Text = "";
                        break;
                    case 99:
                        richTextBox1.Text = "Дан целочисленный массив размера N. Удалить из массива все элементы, встречающиеся более двух раз, и вывести размер полученного массива и его содержимое.";
                        richTextBox2.Text = "";
                        break;
                    case 100:
                        richTextBox1.Text = "Дан целочисленный массив размера N. Удалить из массива все элементы, встречающиеся ровно два раза, и вывести размер полученного массива и его содержимое.";
                        richTextBox2.Text = "";
                        break;
                    case 101:
                        richTextBox1.Text = "Дан массив размера N и целое число K (1 ≤ K ≤ N). Перед элементом массива с порядковым номером K вставить новый элемент с нулевым значением.";
                        richTextBox2.Text = "";
                        break;
                    case 102:
                        richTextBox1.Text = "Дан массив размера N и целое число K (1 ≤ K ≤ N). После элемента массива с порядковым номером K вставить новый элемент с нулевым значением.";
                        richTextBox2.Text = "";
                        break;
                    case 103:
                        richTextBox1.Text = "Дан массив размера N. Вставить элемент с нулевым значением перед минимальным и после максимального элемента массива.";
                        richTextBox2.Text = "";
                        break;
                    case 104:
                        richTextBox1.Text = "Дан массив размера N и два целых числа K и M (1 ≤ K ≤ N, 1 ≤ M ≤ 10). Перед элементом массива с номером K вставить M новых элементов с нулевыми значениями.";
                        richTextBox2.Text = "";
                        break;
                    case 105:
                        richTextBox1.Text = "Дан массив размера N и два целых числа K и M (1 ≤ K ≤ N, 1 ≤ M ≤ 10). После элемента массива с номером K вставить M новых элементов с нулевыми значениями.";
                        richTextBox2.Text = "";
                        break;
                    case 106:
                        richTextBox1.Text = "Дан массив размера N. Продублировать в нем элементы с четными номерами (2, 4, …). Условный оператор не использовать.";
                        richTextBox2.Text = "";
                        break;
                    case 107:
                        richTextBox1.Text = "Дан массив размера N. Утроить в нем вхождения всех элементов с нечетными номерами (1, 3, …). Условный оператор не использовать.";
                        richTextBox2.Text = "";
                        break;
                    case 108:
                        richTextBox1.Text = "Дан массив размера N. Перед каждым положительным элементом массива вставить элемент с нулевым значением.";
                        richTextBox2.Text = "";
                        break;
                    case 109:
                        richTextBox1.Text = "Дан массив размера N. После каждого отрицательного элемента массива вставить элемент с нулевым значением.";
                        richTextBox2.Text = "";
                        break;
                    case 110:
                        richTextBox1.Text = "Дан целочисленный массив размера N. Продублировать в нем все четные числа.";
                        richTextBox2.Text = "";
                        break;
                    case 111:
                        richTextBox1.Text = "Дан целочисленный массив размера N. Утроить в нем вхождения всех нечетных чисел.";
                        richTextBox2.Text = "";
                        break;
                    case 112:
                        richTextBox1.Text = "Дан массив A размера N > 6. Упорядочить его по возрастанию методом сортировки простым обменом («пузырьковой» сортировкой): просматривать массив, сравнивая его соседние элементы (A1 и A2, A2 и A3 и т. д.) и меняя их местами, если левый элемент пары больше правого; повторить описанные действия N-1 раз. Для контроля за выполняемыми действиями выводить содержимое массива после каждого просмотра. Учесть, что при каждом просмотре количество анализируемых пар можно уменьшить на 1.";
                        richTextBox2.Text = "";
                        break;
                    case 113:
                        richTextBox1.Text = "Дан массив A размера N ≤ 6. Упорядочить его по возрастанию методом сортировки простым выбором: найти максимальный элемент массива и поменять его местами с последним (N-м) элементом; выполнить описанные действия N-1 раз, каждый раз уменьшая на 1 количество анализируемых элементов и выводя содержимое массива.";
                        richTextBox2.Text = "";
                        break;
                    case 114:
                        richTextBox1.Text = "Дан массив A размера N ≤ 6. Упорядочить его по возрастанию методом сортировки простыми вставками: сравнить элементы A1 и A2 и, при необходимости меняя их местами, добиться того, чтобы они оказались упорядоченными по возрастанию; затем обратиться к элементу A3 и переместить его в левую (уже упорядоченную) часть массива, сохранив ее упорядоченность; повторить этот процесс для остальных элементов, выводя содержимое массива после обработки каждого элемента (от 2-го до N-го). При выполнении описанных действий удобно использовать прием «барьера», записывая очередной элемент перед его обработкой в дополнительный элемент массива A0.";
                        richTextBox2.Text = "";
                        break;
                    case 115:
                        richTextBox1.Text = "Дан массив A размера N. Не изменяя данный массив, вывести номера его элементов в том порядке, в котором соответствующие им элементы образуют возрастающую последовательность. Использовать метод «пузырьковой» сортировки (см. задание Array112), модифицировав его следующим образом: создать вспомогательный целочисленный массив номеров I, заполнив его числами от 1 до N; просматривать массив A, сравнивая пары элементов массива A с номерами I1 и I2, I2 и I3, … и меняя местами соответствующие элементы массива I, если левый элемент пары больше правого. Повторив описанную процедуру просмотра N — 1 раз, получим в массиве I требуемую последовательность номеров.";
                        richTextBox2.Text = "";
                        break;
                    case 116:
                        richTextBox1.Text = "Дан целочисленный массив A размера N. Назовем серией группу подряд идущих одинаковых элементов, а длиной серии − количество этих элементов (длина серии может быть равна 1). Сформировать два новых целочисленных массива B и C одинакового размера, записав в массив B длины всех серий исходного массива, а в массив C − значения элементов, образующих эти серии.";
                        richTextBox2.Text = "";
                        break;
                    case 117:
                        richTextBox1.Text = "Дан целочисленный массив размера N. Вставить перед каждой его серией элемент с нулевым значением.";
                        richTextBox2.Text = "";
                        break;
                    case 118:
                        richTextBox1.Text = "Дан целочисленный массив размера N. Вставить после каждой его серии элемент с нулевым значением.";
                        richTextBox2.Text = "";
                        break;
                    case 119:
                        richTextBox1.Text = "Дан целочисленный массив размера N. Преобразовать массив, увеличив каждую его серию на один элемент.";
                        richTextBox2.Text = "";
                        break;
                    case 120:
                        richTextBox1.Text = "Дан целочисленный массив размера N,содержащий по крайней мере одну серию, длина которой больше 1. Преобразовать массив, уменьшив каждую его серию на один элемент (определение серии дано в задании Array116).";
                        richTextBox2.Text = "";
                        break;
                    case 121:
                        richTextBox1.Text = "Дано целое число K (>0) и целочисленный массив размера N. Преобразовать массив, удвоив длину его серии с номером K (определение серии дано в задании Array116). Если серий в массиве меньше K, то вывести массив без изменений.";
                        richTextBox2.Text = "";
                        break;
                    case 122:
                        richTextBox1.Text = "Дано целое число K (>1) и целочисленный массив размера N. Удалить из массива серию с номером K (определение серии дано в задании Array116). Если серий в массиве меньше K, то вывести массив без изменений.";
                        richTextBox2.Text = "";
                        break;
                    case 123:
                        richTextBox1.Text = "Дано целое число K (>1) и целочисленный массив размера N. Поменять местами первую серию массива и его серию с номером K (определение серии дано в задании Array116). Если серий в массиве меньше K, то вывести массив без изменений.";
                        richTextBox2.Text = "";
                        break;
                    case 124:
                        richTextBox1.Text = "Дано целое число K (>0) и целочисленный массив размера N. Поменять местами последнюю серию массива и его серию с номером K (определение серии дано в задании Array116). Если серий в массиве меньше K, то вывести массив без изменений.";
                        richTextBox2.Text = "";
                        break;
                    case 125:
                        richTextBox1.Text = "Дано целое число L (>1) и целочисленный массив размера N. Заменить каждую серию массива, длина которой меньше L, на один элемент с нулевым значением (определение серии дано в задании Array116).";
                        richTextBox2.Text = "";
                        break;
                    case 126:
                        richTextBox1.Text = "Дано целое число L (>0) и целочисленный массив размера N. Заменить каждую серию массива, длина которой равна L, на один элемент с нулевым значением (определение серии дано в задании Array116).";
                        richTextBox2.Text = "";
                        break;
                    case 127:
                        richTextBox1.Text = "Дано целое число L (>0) и целочисленный массив размера N. Заменить каждую серию массива, длина которой больше L, на один элемент с нулевым значением (определение серии дано в задании Array116).";
                        richTextBox2.Text = "";
                        break;
                    case 128:
                        richTextBox1.Text = "Дан целочисленный массив размера N. Преобразовать массив, увеличив его первую серию наибольшей длины на один элемент (определение серии дано в задании Array116).";
                        richTextBox2.Text = "";
                        break;
                    case 129:
                        richTextBox1.Text = "Дан целочисленный массив размера N. Преобразовать массив, увеличив его последнюю серию наибольшей длины на один элемент (определение серии дано в задании Array116).";
                        richTextBox2.Text = "";
                        break;
                    case 130:
                        richTextBox1.Text = "Дан целочисленный массив размера N. Преобразовать массив, увеличив все его серии наибольшей длины на один элемент (определение серии дано в задании Array116).";
                        richTextBox2.Text = "";
                        break;
                    case 131:
                        richTextBox1.Text = "Дано множество A из N точек на плоскости и точка B (точки заданы своими координатами x, y). Найти точку из множества A, наиболее близкую к точке B. Расстояние R между точками с координатами (x1, y1) и (x2, y2) вычисляется по формуле: R =q(x2−x1)2 + (y2−y1)2";
                        richTextBox2.Text = "";
                        break;
                    case 132:
                        richTextBox1.Text = "Дано множество A из N точек (точки заданы своими координатами x, y). Среди всех точек этого множества, лежащих во второй четверти, найти точку, наиболее удаленную от начала координат. Если таких точек нет, то вывести точку с нулевыми координатами.";
                        richTextBox2.Text = "";
                        break;
                    case 133:
                        richTextBox1.Text = "Дано множество A из N точек (точки заданы своими координатами x, y). Среди всех точек этого множества, лежащих в первой или третьей четверти, найти точку, наиболее близкую к началу координат. Если таких точек нет, то вывести точку с нулевыми координатами.";
                        richTextBox2.Text = "";
                        break;
                    case 134:
                        richTextBox1.Text = "Дано множество A из N точек (точки заданы своими координатами x, y). Найти пару различных точек этого множества с максимальным расстоянием между ними и само это расстояние (точки выводятся в том же порядке, в котором они перечислены при задании множества A).";
                        richTextBox2.Text = "";
                        break;
                    case 135:
                        richTextBox1.Text = "Даны множества A и B, состоящие соответственно из N1 и N2 точек (точки заданы своими координатами x, y). Найти минимальное расстояние между точками этих множеств и сами точки, расположенные на этом расстоянии (вначале выводится точка из множества A, затем точка из множества B).";
                        richTextBox2.Text = "";
                        break;
                    case 136:
                        richTextBox1.Text = "Дано множество A из N точек (N > 2, точки заданы своими координатами x, y). Найти такую точку из данного множества, сумма расстояний от которой до остальных его точек минимальна, и саму эту сумму.";
                        richTextBox2.Text = "";
                        break;
                    case 137:
                        richTextBox1.Text = "Дано множество A из N точек (N > 2, точки заданы своими координатами x, y). Найти наибольший периметр треугольника, вершины которого принадлежат различным точкам множества A, и сами эти точки (точки выводятся в том же порядке, в котором они перечислены при задании множества A).";
                        richTextBox2.Text = "";
                        break;
                    case 138:
                        richTextBox1.Text = "Дано множество A из N точек (N > 2, точки заданы своими координатами x, y). Найти наименьший периметр треугольника, вершины которого принадлежат различным точкам множества A, и сами эти точки (точки выводятся в том же порядке, в котором они перечислены при задании множества A).";
                        richTextBox2.Text = "";
                        break;
                    case 139:
                        richTextBox1.Text = "Дано множество A из N точек с целочисленными координатами x, y. Порядок на координатной плоскости определим следующим образом: (x1, y1) < (x2, y2), если либо x1 < x2, либо x1 = x2 и y1 < y2. Расположить точки данного множества по возрастанию в соответствии с указанным порядком.";
                        richTextBox2.Text = "";
                        break;
                    case 140:
                        richTextBox1.Text = "Дано множество A из N точек с целочисленными координатами x, y. Порядок на координатной плоскости определим следующим образом: (x1, y1) < (x2, y2), если либо x1 +y1 < x2 +y2, либо x1 +y1 = x2 +y2 и x1 < x2. Расположить точки данного множества по убыванию в соответствии с указанным порядком.";
                        richTextBox2.Text = "";
                        break;
                    default:
                        richTextBox1.Text = "";
                        richTextBox2.Text = "";
                        break;
                }
            }


            if (comboBox1.SelectedIndex == 9)   // Задачи с String(1-70)
            {
                switch (comboBox2.SelectedIndex + 1)
                {
                    case 1:
                        richTextBox1.Text = "Дан символ C. Вывести его код (то есть номер в кодовой таблице).";
                        richTextBox2.Text = "# include <iostream>\n# include <windows.h>\n# include <cmath>\n# include <iomanip>\n# include <fstream>\nusing namespace std;\nint main()\n{ \n	SetConsoleCP(1251);\n	SetConsoleOutputCP(1251);\n	unsigned char C;\n	int kod;\n	cout << \"Введите символ С: \";\n	cin >> C;\n	kod = C;\n	cout << \"Код символа \" << C << \": \" << kod << endl;\n	system(\"pause\");\n	return 0;\n}";
                        break;
                    case 2:
                        richTextBox1.Text = "Дано целое число N (32 ≤ N ≤ 126). Вывести символ с кодом, равным N.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int n;\n    cin >> n;\n    cout << char(n);\n    return 0;\n}";
                        break;
                    case 3:
                        richTextBox1.Text = "ДансимволC.Вывестидвасимвола,первыйизкоторыхпредшествует символу C в кодовой таблице, а второй следует за символом C.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    char c;\n    cin >> c;\n    cout << char(int(c) - 1) << \" \" << char(int(c) + 1);\n    return 0;\n}";
                        break;
                    case 4:
                        richTextBox1.Text = "Дано целое число N (1 ≤ N ≤ 26). Вывести N первых прописных (то есть заглавных) букв латинского алфавита.";
                        richTextBox2.Text = "# include <iostream>\n# include <windows.h>\n# include <cmath>\n# include <iomanip>\nusing namespace std;\nint main()\n{ \n	SetConsoleCP(1251);\n	SetConsoleOutputCP(1251);\n	\n	int N;\n	cout << \"Введите число N от 1 до 26: \";\n	cin >> N;\n	for (char c = \'A\'; c < \'A\' + N; ++c) {		\n		cout << c << \" \";\n	}\n	cout << endl;\n	system(\"pause\");\n	return 0;\n}";
                        break;
                    case 5:
                        richTextBox1.Text = "Дано целое число N (1≤N ≤26). Вывести N последних строчных (то есть маленьких) букв латинского алфавита в обратном порядке (начиная с буквы «z»).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int n, z = 122;\n    cin >> n;\n    while (n) {        \n        cout << char(z) << \" \";\n        --n;\n        --z;\n    }\n    return 0;\n}";
                        break;
                    case 6:
                        richTextBox1.Text = "Дан символ C, изображающий цифру или букву (латинскую или русскую). Если C изображает цифру, то вывести строку «digit», если латинскую букву — вывести строку «lat», если русскую — вывести строку «rus».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    char c;\n    cin >> c;\n    if ((c >= \'a\' && c <= \'z\') || (c >= \'A\' && c <= \'Z\'))\n        cout << \"lat\" << \" \";\n    else if (c >= \'1\' && c <= \'9\')\n        cout << \"digit\";\n    else\n        cout << \"rus\";\n    return 0;\n}";
                        break;
                    case 7:
                        richTextBox1.Text = "Дана непустая строка. Вывестикоды ее первого и последнего символа.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    string s;\n    cin >> s;\n    cout << int(s[0]) << \" \" << int(s[s.size() - 1]);\n    return 0;\n}";
                        break;
                    case 8:
                        richTextBox1.Text = "Дано целое число N (>0) и символ C. Вывести строку длины N, которая состоит из символов C.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int n, i = 0;\n    cin >> n;\n    char c;\n    cin >> c;\n    for (int i = 0; i < n; ++i) {        \n        cout << c << \" \";\n    }\n    return 0;\n}";
                        break;
                    case 9:
                        richTextBox1.Text = "Дано четное число N (>0) и символы C1 и C2. Вывести строку длины N, которая состоит из чередующихся символов C1 и C2, начиная с C1.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int n, i = 0;\n    cin >> n;\n    char c, c1;\n    cin >> c >> c1;\n    while (n) {        \n        if (i % 2 == 0)\n            cout << c;\n        else\n            cout << c1;\n        cout << \" \";\n        ++i;\n        --n;\n    }\n    return 0;\n}";
                        break;
                    case 10:
                        richTextBox1.Text = "Дана строка. Вывести строку, содержащую те же символы, но расположенные в обратном порядке.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    string s;\n    cin >> s;\n    reverse(s.begin(), s.end());\n    cout << s;\n    return 0;\n}";
                        break;
                    case 11:
                        richTextBox1.Text = "Дана непустая строка S.Вывести строку,содержащую символы строки S, между которыми вставлено по одному пробелу.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    string s;\n    cin >> s;\n    for (int i = 0; i < s.size(); ++i) {        \n        cout << s[i] << \' \';\n    }\n    return 0;\n}";
                        break;
                    case 12:
                        richTextBox1.Text = "Дана непустая строка S и целое число N (>0). Вывести строку, содержащую символы строки S, между которыми вставлено по N символов «*» (звездочка).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    string s;\n    cin >> s;\n    int n;\n    cin >> n;\n    for (int i = 0; i < s.size() - 1; ++i) {        \n        cout << s[i];\n        for (int j = 0; j < n; ++j)\n            cout << \'*\';\n    }\n    cout << s[s.size() - 1];\n    return 0;\n}";
                        break;
                    case 13:
                        richTextBox1.Text = "Дана строка. Подсчитать количество содержащихся в ней цифр.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int k = 0;\n    string s;\n    cin >> s;\n    for (int i = 0; i < s.size(); ++i) {        \n        if (s[i] >= \'1\' && s[i] <= \'9\')\n            ++k;\n    }\n    cout << k;\n    return 0;\n}";
                        break;
                    case 14:
                        richTextBox1.Text = "Дана строка. Подсчитать количество содержащихся в ней прописных латинских букв.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int k = 0;\n    string s;\n    cin >> s;\n    for (int i = 0; i < s.size(); ++i) {        \n        if (s[i] >= \'a\' && s[i] <= \'z\')\n            ++k;\n    }\n    cout << k;\n    return 0;\n}";
                        break;
                    case 15:
                        richTextBox1.Text = "Дана строка. Подсчитать общее количество содержащихся в ней строчных латинских и русских букв.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int lat = 0, rus = 0;\n    string s;\n    cin >> s;\n    for (int i = 0; i < s.size(); ++i) {        \n        if (s[i] >= \'a\' && s[i] <= \'z\')\n            ++lat;\n        if (s[i] >= \'а\' && s[i] <= \'я\')\n            ++rus;\n    }\n    cout << lat << \" \" << rus << endl;\n    return 0;\n}";
                        break;
                    case 16:
                        richTextBox1.Text = "Дана строка. Преобразовать в ней все прописные латинские буквы в строчные.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    string s;\n    cin >> s;\n    for (int i = 0; i < s.size(); ++i) {        \n        if (s[i] >= \'A\' && s[i] <= \'Z\')\n            s[i] += 32;\n    }\n    cout << s;\n    return 0;\n}";
                        break;
                    case 17:
                        richTextBox1.Text = "Дана строка. Преобразовать в ней все строчные буквы (как латинские, так и русские) в прописные.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    string s;\n    cin >> s;\n    for (int i = 0; i < s.size(); ++i) {        \n        if (s[i] >= \'a\' && s[i] <= \'z\')\n            s[i] -= 32;\n    }\n    cout << s;\n    return 0;\n}";
                        break;
                    case 18:
                        richTextBox1.Text = "Дана строка. Преобразовать в ней все строчные буквы (как латинские, так и русские) в прописные, а прописные — в строчные.";
                        richTextBox2.Text = "# include <iostream>\n# include <windows.h>\n# include <cmath>\n# include <iomanip>\n# include <fstream>\n# define MAXSIZE  100\nusing namespace std;\nint main()\n{	\n	SetConsoleCP(1251);\n	SetConsoleOutputCP(1251);\n	\n	char str[MAXSIZE] = \"\";\n	\n	ifstream in(\"String18.txt\");\n	in.getline(str, sizeof(str));\n	cout << \"Дана строка:\" << endl;\n	cout << str << endl;\n	\n	for (int i = 0; i < strlen(str); ++i) {		\n		if (islower(str[i])) str[i] = toupper(str[i]);\n		else if (isupper(str[i])) str[i] = tolower(str[i]);\n			\n		if (\'А\' <= str[i] && str[i] <= \'Я\') str[i] = str[i] + 32;\n		else if (\'а\' <= str[i] && str[i] <= \'я\') str[i] = str[i] - 32;\n	}\n	cout << \"Преобразованная строка:\" << endl;\n	cout << str << endl;\n	system(\"pause\");\n	return 0;\n}";
                        break;
                    case 19:
                        richTextBox1.Text = "Дана строка. Если она представляет собой запись целого числа, то вывести 1, если вещественного (с дробной частью) — вывести 2; если строку нельзя преобразовать в число, то вывести 0. Считать, что дробная часть вещественного числа отделяется от его целой части десятичной точкой «.».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    string s;\n    cin >> s;\n    for (int i = 0; i < s.size(); ++i) {        \n        if ((s[i] < \'0\' || s[i] > \'9\') && s[i] != \'.\') {            \n            cout << 0;\n            return 0;\n        }\n    }\n    int pos = s.find(\'.\');\n    if (pos + 1) {        \n        if (s.find(\'.\', pos + 1) + 1)\n            cout << 0;\n        else\n            cout << 2;\n    }\n    else\n        cout << 1;\n    return 0;\n}";
                        break;
                    case 20:
                        richTextBox1.Text = "Дано целое положительное число.Вывести символы,изображающие цифры этого числа (в порядке слева направо).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int n;\n    string s;\n    cin >> n;\n    s = to_string(n);\n    for (auto i : s)\n        cout << i << \" \";\n    return 0;\n}";
                        break;
                    case 21:
                        richTextBox1.Text = "Дано целое положительное число.Вывести символы,изображающие цифры этого числа (в порядке справа налево).";
                        richTextBox2.Text = "#include <bits/stdc++.h>\nusing namespace std;\nint main()\n{ \n    int n;\n    string s;\n    cin >> n;\n    s = to_string(n);\n    for (int i = s.size() - 1; i >= 0; --i)\n        cout << s[i] << \" \";\n    return 0;\n}";
                        break;
                    case 22:
                        richTextBox1.Text = "Дана строка, изображающая целое положительное число. Вывести сумму цифр этого числа.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int sum = 0;\n    string s;\n    cin >> s;\n    for (int i = 0; i < s.size(); ++i) {        \n        sum += s[i] - 48;\n    }\n    cout << sum;\n    return 0;\n}";
                        break;
                    case 23:
                        richTextBox1.Text = "Дана строка, изображающая арифметическое выражение вида «<цифра>±<цифра>±...±<цифра>», где на месте знака операции «±» находится символ «+» или «−» (например, «4+7−2−8»). Вывести значение данного выражения (целое число).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    string s;\n    cin >> s;\n    int res = s[0] - 48, operation;\n    for (int i = 1; i < s.size(); ++i) {        \n        if (s[i] == '+')\n            operation = 1;\n        else if (s[i] == '-')\n            operation = -1;\n        else\n            res += operation * (s[i] - 48);\n    }\n    cout << res;\n    return 0;\n}";
                        break;
                    case 24:
                        richTextBox1.Text = "Дана строка, изображающая двоичную запись целого положительного числа. Вывести строку, изображающую десятичную запись этого же числа.";
                        richTextBox2.Text = "#include <iostream>\n\nusing namespace std;\nint main() {    \n    char n[255];\n    cin >> n;\n    int i = strlen(n);\n    int p = 1, m = 0;\n    while (i--) {        \n        m += (n[i] - \'0\') * p;\n        p *= 2;\n    }\n    cout << m;\n    return 0;\n}";
                        break;
                    case 25:
                        richTextBox1.Text = "Дана строка, изображающая десятичную запись целого положительного числа. Вывести строку, изображающую двоичную запись этого же числа.";
                        richTextBox2.Text = "#include <iostream>\n#include <string>\nusing namespace std;\n\nint main()\n{ \n    string s, temp;\n    cin >> s;\n    string srez;\n    int mem = 0;\n    for (srez = \"\";!(s.empty());) {        \n        int i;\n        string s2 = s;\n        mem = 0;\n        for (i = 0;i < (int)s.length();++i) {            \n            s2[i] = (char)(((((int)(s[i]) - 48) + 10 * mem) / 2) + 48);\n            if ((((int)(s[i]) - 48) % 2) == 1) { mem = 1; }\n            else { mem = 0; }\n        };\n        if (s2[0] == \'0\') { s2.erase(0, 1); }\n        s.swap(s2);\n        srez += char(mem + 48);\n    }\n    int i;\n    for (i = 0;i < (int)srez.length();++i) {        \n        s += srez[srez.length() - i - 1];\n    }\n    cout << s << endl;\n    return 0;\n}";
                        break;
                    case 26:
                        richTextBox1.Text = "Дано целое число N (>0) и строка S. Преобразовать строку S в строку длины N следующим образом: если длина строки S больше N, то отбросить первые символы, если длина строки S меньше N, то в ее начало добавить символы «.» (точка).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    int n;\n    string s;\n    cin >> n >> s;\n    if (s.size() > n)\n        s.erase(0, s.size() - n);\n    else\n        s.insert(s.end(), n - s.size(), \'.\');\n    cout << s << endl;\n    return 0;\n}";
                        break;
                    case 27:
                        richTextBox1.Text = "Даны целые положительные числа N1 и N2 и строки S1 и S2. Получить из этих строк новую строку, содержащую первые N1 символов строки S1 и последние N2 символов строки S2 (в указанном порядке).";
                        richTextBox2.Text = "# include <iostream>\n# include <windows.h>\n# include <cmath>\n# include <fstream>\n# include <iomanip>\nusing namespace std;\nconst int nmax = 100;\nint main()\n{ \n	SetConsoleCP(1251);\n	SetConsoleOutputCP(1251);\n	char s1[nmax];\n	char s2[nmax];\n	char s[2 * nmax];\n	\n	ifstream in(\"String27.txt\");\n	in.getline(s1, sizeof(s1));\n	cout << s1 << endl;\n	in.getline(s2, sizeof(s2));\n	cout << s2 << endl;\n	\n	int n1, n2;\n	int size_s2 = strlen(s2);\n	cout << \"Введите целые положительные числа: n1<=\" << strlen(s1);\n	cout << \" и n2<=\" << size_s2 << \": \";\n	cin >> n1 >> n2;\n	strncpy(s, s1, n1);\n	s[n1] = \'0\';\n	\n	char* p = s2;\n	p += size_s2 - n2;\n	strcat(s, p);\n	\n	cout << s << endl;\n	system(\"pause\");\n	return 0;\n}";
                        break;
                    case 28:
                        richTextBox1.Text = "Дан символ C и строка S. Удвоить каждое вхождение символа C в строку S.";
                        richTextBox2.Text = "#include <iostream>\n#include <string>\nusing namespace std;\nint main()\n{ \n    char c;\n    string s;\n    cin >> c >> s;\n    int pos = s.find(c);\n    while (pos + 1) {        \n        s.insert(pos, 1, c);\n        pos = s.find(c, pos + 2);\n    }\n    cout << s;\n    return 0;\n}";
                        break;
                    case 29:
                        richTextBox1.Text = "Дан символ C и строки S, S0. Перед каждым вхождением символа C в строку S вставить строку S0.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    char c;\n    string s, s1;\n    cin >> c >> s >> s1;\n    int pos = s.find(c);\n    while (pos + 1) {        \n        s.insert(pos, s1);\n        pos = s.find(c, pos + s1.size() + 1);\n    }\n    cout << s;\n    return 0;\n}";
                        break;
                    case 30:
                        richTextBox1.Text = "Дан символ C и строки S, S0. После каждого вхождения символа C в строку S вставить строку S0.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main() {    \n    char c;\n    string S, S0;\n    cin >> c >> S >> S0;\n    for (int i = 0; i < S.length(); i++) {        \n        if (S[i] == c) cout << S0;\n        else cout << S[i];\n    }\n    return 0;\n}";
                        break;
                    case 31:
                        richTextBox1.Text = "Даны строки S и S0. Проверить, содержится ли строка S0 в строке S. Если содержится, то вывести TRUE, если не содержится, то вывести FALSE.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    string s, s0;\n    cin >> s >> s0;\n    if (s.find(s0) + 1)\n        cout << \"TRUE\";\n    else\n        cout << \"FALSE\";\n    return 0;\n}";
                        break;
                    case 32:
                        richTextBox1.Text = "Даны строки S и S0. Найти количество вхождений строки S0 в строку S.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{    \n    system(\"chcp 1251\");\n    string s, s0;\n    int k = 0;\n    cin >> s >> s0;\n    int pos = s.find(s0);\n    while (pos + 1) {        \n        ++k;\n        s.find(s0, pos + 1);\n    }\n    cout << k << endl;\n    return 0;\n}";
                        break;
                    case 33:
                        richTextBox1.Text = "Даны строки S и S0. Удалить из строки S первую подстроку, совпадающую с S0. Если совпадающих подстрок нет, то вывести строку S без изменений.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    string s, s0;\n    cin >> s >> s0;\n    int pos = s.find(s0);\n    if (pos + 1)\n        s.erase(pos, s0.size());\n    cout << s;\n    return 0;\n}";
                        break;
                    case 34:
                        richTextBox1.Text = "Даны строки S и S0. Удалить из строки S последнюю подстроку, совпадающую с S0. Если совпадающих подстрок нет, то вывести строку S без изменений.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    string s, s0;\n    cin >> s >> s0;\n    int pos = s.rfind(s0);\n    if (pos + 1)\n        s.erase(pos, s0.size());\n    cout << s;\n    return 0;\n}";
                        break;
                    case 35:
                        richTextBox1.Text = "Даны строки S и S0. Удалить из строки S все подстроки, совпадающие с S0. Если совпадающих подстрок нет, то вывести строку S без изменений.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main() {    \n    string s, s0;\n    cin >> s >> s0;\n    for (int i = s.size() - 1; i >= 0; i--) {        \n        if (s.substr(i, s0.size()) == s0)\n            s.erase(i, s0.size());\n    }\n    cout << s << endl;\n    return 0;\n}";
                        break;
                    case 36:
                        richTextBox1.Text = "Даны строки S, S1 и S2. Заменить в строке S первое вхождение строки S1 на строку S2.";
                        richTextBox2.Text = "#include <iostream>\n#include <string>\nusing namespace std;\nint main()\n{ \n    string s, s1, s2;\n    cin >> s >> s1 >> s2;\n    int pos = s.find(s1);\n    if (pos + 1) {        \n        s.replace(pos, s1.size(), s2);\n    }\n    cout << s;\n    return 0;\n}";
                        break;
                    case 37:
                        richTextBox1.Text = "Даны строки S, S1 и S2. Заменить в строке S последнее вхождение строки S1 на строку S2.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    string s, s1, s2;\n    cin >> s >> s1 >> s2;\n    int pos = s.rfind(s1);\n    if (pos + 1) {        \n        s.replace(pos, s1.size(), s2);\n    }\n    cout << s;\n    return 0;\n}";
                        break;
                    case 38:
                        richTextBox1.Text = "Даны строки S, S1 и S2. Заменить в строке S все вхождения строки S1 на строку S2.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    string s, s1, s2;\n    cin >> s >> s1 >> s2;\n    int pos = s.find(s1);\n    while (pos + 1) {        \n        s.replace(pos, s1.size(), s2);\n        pos = s.find(s1);\n    }\n    cout << s;\n    return 0;\n}";
                        break;
                    case 39:
                        richTextBox1.Text = "Дана строка, содержащая по крайней мере один символ пробела. Вывести подстроку, расположенную между первым и вторым пробелом исходной строки. Если строка содержит только один пробел, то вывести пустую строку.";
                        richTextBox2.Text = "#include <iostream>\n#include <string>\n#include <cstring>\nusing namespace std;\nint main()\n{ \n    string s;\n    getline(cin, s);\n    int pos = s.find(\' \');\n    cout << s.substr(0, pos) << \" \" << s.substr(pos + 1) << endl;\n    return 0;\n}";
                        break;
                    case 40:
                        richTextBox1.Text = "Дана строка, содержащая по крайней мере один символ пробела. Вывести подстроку, расположенную между первым и последним пробелом исходной строки. Если строка содержит только один пробел, то вывести пустую строку.";
                        richTextBox2.Text = "#include <iostream>\n#include <string>\nusing namespace std;\nint main()\n{ \n    string s;\n    getline(cin, s);\n    int pos = s.find(\" \");\n    int pos1 = s.rfind(\" \");\n    if (pos1 + 1 && pos != pos1) {        \n        cout << s.substr(pos + 1, pos1 - pos);\n    }\n    return 0;\n}";
                        break;
                    case 41:
                        richTextBox1.Text = "Дана строка, состоящая из русских слов, разделенных пробелами (одним или несколькими). Найти количество слов в строке.";
                        richTextBox2.Text = "# include <iostream>\n# include <windows.h>\n# include <cmath>\n# include <iomanip>\n# include <fstream>\nusing namespace std;\nconst int nmax = 100;\nint main()\n{ \n	SetConsoleCP(1251);\n	SetConsoleOutputCP(1251);\n	\n	char str[nmax] = \"\";\n	ifstream in(\"String41.txt\");\n	in.getline(str, sizeof(str));\n	cout << \"Исходная строка:\" << endl;\n	cout << str << endl;\n	int answer = 0;\n	char* ptr;\n	ptr = strtok(str, \" ,.\");\n	while (ptr != NULL) {		\n		ptr = strtok(NULL, \" ,.\");\n		++answer;\n	}\n		\n	cout << \"Количество слов в строке = \" << answer << endl;\n	system(\"pause\");\n}";
                        break;
                    case 42:
                        richTextBox1.Text = "Дана строка, состоящая из русских слов, набранных заглавными буквами и разделенных пробелами (одним или несколькими). Найти количество слов, которые начинаются и заканчиваются одной и той же буквой.";
                        richTextBox2.Text = "#include <iostream>\n#include <string>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    string s;\n    getline(cin, s);\n    s += \" \";\n    s.insert(0, 1, \' \');\n    int k = 0;\n    int pos = s.find(\' \'), pos1 = pos;\n    while (pos + 1) {        \n        pos1 = s.find(\' \', pos + 1);\n        if (s[pos + 1] == s[pos1 - 1] && s[pos1 - 1] != \' \' && s[pos + 1] != \' \') {            \n            ++k;\n        }\n        pos = pos1;\n    }\n    cout << --k << endl;\n    return 0;\n}";
                        break;
                    case 43:
                        richTextBox1.Text = "Дана строка, состоящая из русских слов, набранных заглавными буквами и разделенных пробелами (одним или несколькими). Найти количество слов, которые содержат хотя бы одну букву «А».";
                        richTextBox2.Text = "#include <iostream>\n#include <string>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    string s;\n    int k = 0;\n    getline(cin, s);\n    bool b = true;\n    for (int i = 0; i < s.size(); ++i) {        \n        if (s[i] == \'А\' && b) {            \n            ++k;\n            b = false;\n        }\n        else if (s[i] == \' \')\n            b = true;\n    }\n    cout << k << endl;\n    return 0;\n}";
                        break;
                    case 44:
                        richTextBox1.Text = "Дана строка, состоящая из русских слов, набранных заглавными буквами и разделенных пробелами (одним или несколькими). Найти количество слов, которые содержат ровно три буквы «А».";
                        richTextBox2.Text = "#include <iostream>\n#include <string>\n#include <clocale>\n#include <Windows.h>\nusing namespace std;\n\nint main() {	\n	SetConsoleCP(1251);\n	SetConsoleOutputCP(1251);\n	setlocale(LC_ALL, \"Rus\");\n	string s;\n	int a = 0, kol = 0;\n	getline(cin, s);\n		\n	for (int i = 0; i < s.length(); i++)\n	{ \n		if (s[i] == \'А\') {			\n			a++;\n			if (a == 3) {				\n				kol++;\n			}\n			else if (a > 3) {				\n				kol--;\n				break;\n			}\n				\n		}\n	\n		else if (s[i] == \' \')\n			a = 0;\n	}\n	cout << kol;\n}";
                        break;
                    case 45:
                        richTextBox1.Text = "Дана строка, состоящая из русских слов, разделенных пробелами (одним или несколькими). Найти длину самого короткого слова.";
                        richTextBox2.Text = "#include <iostream>\n#include <string>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    string s;\n    getline(cin, s);\n    int res = INT_MAX, k = INT_MAX;\n    s.insert(0, 1, \' \');\n    s += \" \";\n    for (int i = 0; i < s.size(); ++i) {        \n        if (s[i] != \' \') {            \n            k = 1;\n            while (s[++i] != \' \')\n                ++k;\n        }\n        res = min(res, k);\n    }\n    cout << res << endl;\n    return 0;\n}";
                        break;
                    case 46:
                        richTextBox1.Text = "Дана строка, состоящая из русских слов, разделенных пробелами (одним или несколькими). Найти длину самого длинного слова.";
                        richTextBox2.Text = "#include <iostream>\n#include <string>\nusing namespace std;\nint main() {    \n    setlocale(LC_ALL, \"\");\n    string words;\n    cin >> words;\n    int max = 0;\n    int current = 0;\n    getline(cin, words);\n    for (int i = 0; i < words.length(); i++)\n    { \n        if (words[i] != \' \')\n            current++;\n        else if (words[i] == \' \')\n            current = 0;\n    }\n    if (current > max)\n        max = current;\n    cout << max;\n    return 0;\n}";
                        break;
                    case 47:
                        richTextBox1.Text = "Дана строка, состоящая из русских слов, разделенных пробелами (одним или несколькими). Вывести строку, содержащую эти же слова, разделенные одним символом«.»(точка).В конце строки точку не ставить.";
                        richTextBox2.Text = "#include <iostream>\n#include <string>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    string s;\n    getline(cin, s);\n    for (int i = 1; i < s.size(); i += 2) {        \n        s.insert(i, 1, \'.\');\n    }\n    cout << s << endl;\n    return 0;\n}";
                        break;
                    case 48:
                        richTextBox1.Text = "Дана строка, состоящая из русских слов, набранных заглавными буквами и разделенных пробелами (одним или несколькими). Преобразовать каждое слово в строке, заменив в нем все последующие вхождения его первой буквы на символ «.» (точка). Например, слово «МИНИМУМ» надо преобразовать в «МИНИ.У.». Количество пробелов между словами не изменять.";
                        richTextBox2.Text = "#include <iostream>\n#include <string>\nusing namespace std;\nint main()\n{ \n    string s;\n    getline(cin, s);\n    for (int i = 1; i < s.size(); ++i) {        \n        if (s[i] == s[0])\n            s[i] = \'.\';\n    }\n    cout << s;\n    return 0;\n}";
                        break;
                    case 49:
                        richTextBox1.Text = "Дана строка, состоящая из русских слов, набранных заглавными буквами и разделенных пробелами (одним или несколькими). Преобразовать каждое слово в строке, заменив в нем все предыдущие вхождения его последней буквы на символ «.» (точка). Например, слово «МИНИМУМ» надо преобразовать в «.ИНИ.УМ». Количество пробелов между словами не изменять.";
                        richTextBox2.Text = "#include <iostream>\n#include <string>\nusing namespace std;\nint main()\n{ \n    string s;\n    getline(cin, s);\n    for (int i = 1; i < s.size(); ++i) {        \n        if (s[i] == s[0])\n            s[i] = \'.\';\n    }\n    cout << s;\n    return 0;\n}";
                        break;
                    case 50:
                        richTextBox1.Text = "Дана строка, состоящая из русских слов, разделенных пробелами (одним или несколькими). Вывести строку, содержащую эти же слова, разделенные одним пробелом и расположенные в обратном порядке.";
                        richTextBox2.Text = "#include <bits/stdc++.h>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    string s;\n    getline(cin, s);\n    int k = 0;\n    s.insert(0, 1, ' ');\n    vector<string> res;\n    for (int i = s.size() - 1; i >= 0; --i) {        \n        if (s[i] != \' \') {            \n            k = 1;\n            while (s[--i] != \' \')\n                ++k;\n        }\n        res.push_back(s.substr(i + 1, k));\n    }\n    for (auto i : res)\n        cout << i << \" \";\n    return 0;\n}";
                        break;
                    case 51:
                        richTextBox1.Text = "Дана строка, состоящая из русских слов, набранных заглавными буквами и разделенных пробелами (одним или несколькими). Вывести строку, содержащую эти же слова, разделенные одним пробелом и расположенные в алфавитном порядке.";
                        richTextBox2.Text = "# include <iostream>\n# include <windows.h>\n# include <cmath>\n# include <iomanip>\n# include <fstream>\nusing namespace std;\nconst int M = 20;\nconst int N = 50;\nint main()\n{ \n    SetConsoleCP(1251);\n    SetConsoleOutputCP(1251);\n    \n    int i, j;\n    char words[M][N];\n    char str[M * N] = \"\";\n    ifstream in(\"String51.txt\");\n    in.getline(str, sizeof(str));\n    cout << \"Исходный набор слов:\" << endl;\n    cout << str << endl;\n    \n    char* ptr;\n    ptr = strtok(str, \" ,.\");\n    int n = 0;\n    while (ptr != NULL)\n    { \n        strcpy(words[n], ptr);\n        ptr = strtok(NULL, \" ,.\");\n        ++n;\n        \n    }\n        \n    char cur[N] = \"\"; \n        \n    for (i = 0;i < n - 1;++i) {        \n        for (j = i + 1;j < n;++j)\n            if (strcmp(words[i], words[j]) > 0)\n            { \n                strcpy(cur, words[i]);\n                strcpy(words[i], words[j]);\n                strcpy(words[j], cur);\n            }\n    }\n        \n    cout << endl;\n    cout << \"Набор слов в алфавитном порядке:\" << endl;\n    char s[M * N] = \"\";\n    strcat(s, words[0]);\n    for (i = 1;i < n;++i) {        \n        strcat(s, \" \");\n        strcat(s, words[i]);\n    }\n    cout << s << endl;\n    system(\"pause\");\n}";
                        break;
                    case 52:
                        richTextBox1.Text = "Дана строка-предложение на русском языке. Преобразовать строку так, чтобы каждое слово начиналось с заглавной буквы. Словом считать набор символов,не содержащий пробелов и ограниченный пробелами или началом/концом строки. Слова, не начинающиеся с буквы, не изменять.";
                        richTextBox2.Text = "#include <iostream>\n#include <string>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    string s;\n    getline(cin, s);\n    s.insert(0, 1, \' \');\n    for (int i = 1; i < s.size(); ++i) {        \n        if (s[i - 1] == ' ' && s[i] >= char(224) && s[i] <= char(255))\n            s[i] -= 32;\n    }\n    s.erase(0, 1);\n    cout << s;\n    return 0;\n}";
                        break;
                    case 53:
                        richTextBox1.Text = "Дана строка-предложение на русском языке. Подсчитать количество содержащихся в строке знаков препинания.";
                        richTextBox2.Text = "#include <iostream>\n#include <string>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    string s;\n    getline(cin, s);\n    int k = 0, pos = s.find_first_of(\",!)(-.:;\");\n    while (pos + 1) {        \n        ++k;\n        pos = s.find_first_of(\",!)(-.:;\", pos + 1);\n    }\n    cout << k;\n    return 0;\n}";
                        break;
                    case 54:
                        richTextBox1.Text = "Дана строка-предложение на русском языке. Подсчитать количество содержащихся в строке гласных букв.";
                        richTextBox2.Text = "#include <iostream>\n#include <string>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    int k = 0;\n    string s;\n    getline(cin, s);\n    int pos = s.find_first_of(\"уеоаыи\");\n    while (pos + 1) {        \n        ++k;\n        pos = s.find_first_of(\"уеоаыи\", pos + 1);\n    }\n    cout << k;\n    return 0;\n}";
                        break;
                    case 55:
                        richTextBox1.Text = "Дана строка-предложение на русском языке. Вывести самое длинное слово в предложении. Если таких слов несколько, то вывести первое из них. Словом считать набор символов, не содержащий пробелов, знаков препинания и ограниченный пробелами, знаками препинания или началом/концом строки.";
                        richTextBox2.Text = "#include <Windows.h>\n#include <iostream>\n#include <string>\n\nusing namespace std;\n\nint main() {	\n	SetConsoleCP(1251);\n	SetConsoleOutputCP(1251);\n	string s, temp;\n	int n = 0, max = 0, index, end, begin;\n	getline(cin, s);\n	for (int i = 0; i < s.length(); i++) {		\n		if (s[i] != ' ') {			\n			n++;\n			index = i;\n				\n		}\n			\n		else if (s[i] == ' ') {			\n			n = 0;\n				\n		}\n			\n		if (n > max) {			\n			max = n;\n			end = index + 1;\n			begin = index - n + 1;\n		}\n	}\n	\n	for (int i = begin; i < end; i++) {		\n		cout << s[i];\n	}\n}";
                        break;
                    case 56:
                        richTextBox1.Text = "Дана строка-предложение на русском языке.Вывести самое короткое слово в предложении. Если таких слов несколько, то вывести последнее из них. Словом считать набор символов, не содержащий пробелов, знаков препинания и ограниченный пробелами, знаками препинания или началом/концом строки.";
                        richTextBox2.Text = "#include <bits/stdc++.h>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    string s;\n    getline(cin, s);\n    s.insert(0, 1, ' ');\n    int k = 0;\n    s += \" \";\n    vector<string> res;\n    for (int i = 0; i < s.size(); ++i) {        \n        if (s[i] >= char(192) && s[i] <= char(255)) {            \n            k = 1;\n            while (s[++i] >= char(192) && s[i] <= char(255))\n                ++k;\n        }\n        if (s[i] == ' ' && k)\n            res.push_back(s.substr(i - k, k));\n        else {            \n            while (s[i] != \' \')\n                ++i;\n        }\n    }\n    int mx = res[0].size(); string t = res[0];\n    for (int i = 1; i < res.size(); ++i) {        \n        if (res[i].size() <= mx) {            \n            mx = res[i].size();\n            t = res[i];\n        }\n    }\n    cout << t;\n    return 0;\n}";
                        break;
                    case 57:
                        richTextBox1.Text = "Дана строка-предложение с избыточными пробелами между словами. Преобразовать ее так, чтобы между словами был ровно один пробел.";
                        richTextBox2.Text = "#include <iostream>\n#include <string>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    string s;\n    getline(cin, s);\n    int pos = s.find(\"  \");\n    while (pos + 1) {        \n        s.erase(pos, 1);\n        pos = s.find(\"  \", pos - 1);\n    }\n    cout << s;\n    return 0;\n}";
                        break;
                    case 58:
                        richTextBox1.Text = "Дана строка, содержащая полное имя файла, то есть имя диска, список каталогов (путь), собственно имя и расширение. Выделить из этой строки имя файла (без расширения).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    string s;\n    cin >> s;\n    int pos = s.rfind(char(92));\n    int pos1 = s.rfind(\'.\');\n    cout << s.substr(pos + 1, pos1 - pos - 1);\n    return 0;\n}";
                        break;
                    case 59:
                        richTextBox1.Text = "Дана строка, содержащая полное имя файла, то есть имя диска, список каталогов (путь), собственно имя и расширение. Выделить из этой строки расширение файла (без предшествующей точки).";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    string s;\n    cin >> s;\n    int pos = s.rfind('.');\n    cout << s.substr(pos + 1);\n    return 0;\n}";
                        break;
                    case 60:
                        richTextBox1.Text = "Дана строка, содержащая полное имя файла. Выделить из этой строки название первого каталога (без символов «\\»). Если файл содержится в корневом каталоге, то вывести символ «\\».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    string s;\n    cin >> s;\n    int pos = s.find(char(92));\n    int pos1 = s.find(char(92), pos + 1);\n    cout << s.substr(pos + 1, pos1 - pos - 1);\n    return 0;\n}";
                        break;
                    case 61:
                        richTextBox1.Text = "Дана строка, содержащая полное имя файла. Выделить из этой строки название последнего каталога (без символов «\\»). Если файл содержится в корневом каталоге, то вывести символ «\\».";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    string s;\n    cin >> s;\n    int pos = s.rfind(char(92));\n    int pos1 = s.rfind(char(92), pos - 1);\n    cout << s.substr(pos1 + 1, pos - pos1 - 1);\n    return 0;\n}";
                        break;
                    case 62:
                        richTextBox1.Text = "Дана строка-предложение на русском языке. Зашифровать ее, выполнив циклическую замену каждой буквы на следующую за ней в алфавите и сохранив при этом регистр букв («А» перейдет в «Б», «а» — в «б», «Б» — в «В», «я» — в «а» и т.д.). Букву «ё» в алфавите не учитывать («е» должна переходить в «ж»). Знаки препинания и пробелы не изменять.";
                        richTextBox2.Text = "#include <iostream>\n#include <string>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    string s;\n    getline(cin, s);\n    for (int i = 0; i < s.size(); ++i) {        \n        if (s[i] >= char(224) && s[i] < char(255))\n            s[i] = char(int(s[i]) + 1);\n        else if (s[i] >= char(192) && s[i] < char(223))\n            s[i] = char(int(s[i]) + 1);\n        else if (s[i] == char(255))\n            s[i] = \'а\';\n        else if (s[i] == char(223))\n            s[i] = \'А\';\n    }\n    cout << s;\n    return 0;\n}";
                        break;
                    case 63:
                        richTextBox1.Text = "Дана строка-предложение на русском языке и число K (0 < K < 10). Зашифровать строку, выполнив циклическую замену каждой буквы на букву того же регистра, расположенную в алфавите на K-й позиции после шифруемой буквы (например, для K =2 «А» перейдет в «В», «а» — в «в», «Б» — в «Г», «я» — в «б» и т.д.). Букву «ё» в алфавите не учитывать, знаки препинания и пробелы не изменять.";
                        richTextBox2.Text = "#include <iostream>\n#include <string>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    string s;\n    getline(cin, s);\n    int k;\n    cin >> k;\n    while (k--) {        \n        for (int i = 0; i < s.size(); ++i) {            \n            if (s[i] >= char(224) && s[i] < char(255))\n                s[i] = char(int(s[i]) + 1);\n            else if (s[i] >= char(192) && s[i] < char(223))\n                s[i] = char(int(s[i]) + 1);\n            else if (s[i] == char(255))\n                s[i] = \'а\';\n            else if (s[i] == char(223))\n                s[i] = \'А\';\n        }\n    }\n    cout << s;\n    return 0;\n}";
                        break;
                    case 64:
                        richTextBox1.Text = "Дано зашифрованное предложение на русском языке (способ шифрования описан в задании String63) и кодовое смещение K (0 < K < 10). Расшифровать предложение.";
                        richTextBox2.Text = "#include <iostream>\n#include <string>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    string s;\n    getline(cin, s);\n    int k;\n    cin >> k;\n    while (k--) {        \n        for (int i = 0; i < s.size(); ++i) {            \n            if (s[i] > char(224) && s[i] <= char(255))\n                s[i] = char(int(s[i]) - 1);\n            else if (s[i] > char(192) && s[i] <= char(223))\n                s[i] = char(int(s[i]) - 1);\n            else if (s[i] == char(224))\n                s[i] = \'я\';\n            else if (s[i] == char(192))\n                s[i] = \'Я\';\n        }\n    }\n    cout << s;\n    return 0;\n}";
                        break;
                    case 65:
                        richTextBox1.Text = "Дано зашифрованное предложение на русском языке(способ шифрования описан в задании String63) и его расшифрованный первый символ C. Найти кодовое смещение K и расшифровать предложение.";
                        richTextBox2.Text = "#include <iostream>\n#include <string>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    string s;\n    getline(cin, s);\n    int k = 0;\n    char c;\n    cin >> c;\n    while (s[0] != c) {        \n        if (s[0] > char(224) && s[0] <= char(255))\n            s[0] = char(int(s[0]) - 1);\n        else if (s[0] > char(192) && s[0] <= char(223))\n            s[0] = char(int(s[0]) - 1);\n        else if (s[0] == char(224))\n            s[0] = \'я\';\n        else if (s[0] == char(192))\n            s[0] = \'Я\';\n        ++k;\n    }\n    while (k--) {        \n        for (int i = 1; i < s.size(); ++i) {            \n            if (s[i] > char(224) && s[i] <= char(255))\n                s[i] = char(int(s[i]) - 1);\n            else if (s[i] > char(192) && s[i] <= char(223))\n                s[i] = char(int(s[i]) - 1);\n            else if (s[i] == char(224))\n                s[i] = \'я\';\n            else if (s[i] == char(192))\n                s[i] = \'Я\';\n        }\n    }\n    cout << s;\n    return 0;\n}";
                        break;
                    case 66:
                        richTextBox1.Text = "Дана строка-предложение. Зашифровать ее, поместив вначале все символы, расположенные на четных позициях строки, а затем, в обратном порядке, все символы, расположенные на нечетных позициях (например, строка «Программа» превратится в «ргамамроП»).";
                        richTextBox2.Text = "#include <iostream>\n#include <string>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    string s, s1 = \"\";\n    cin >> s;\n    for (int i = 0; i < s.size(); i++) {        \n        if (i % 2 != 0)\n            cout << s[i];\n        else\n            s1 += s[i];\n    }\n    reverse(s1.begin(), s1.end());\n    cout << s1;\n    return 0;\n}";
                        break;
                    case 67:
                        richTextBox1.Text = "Дано предложение, зашифрованное по правилу, описанному в задании String66. Расшифровать это предложение.";
                        richTextBox2.Text = "#include <iostream>\n#include <string>\nusing namespace std;\nint main()\n{ \n    system(\"chcp 1251\");\n    string s, s1 = \"\";\n    cin >> s;\n    for (int i = 0; i < s.size() / 2; ++i) {        \n        cout << s[s.size() - i - 1] << s[i];\n    }\n    if (s.size() % 2)\n        cout << s[s.size() / 2];\n    return 0;\n}";
                        break;
                    case 68:
                        richTextBox1.Text = "Дана строка, содержащая цифры и строчные латинские буквы. Если буквы в строке упорядочены по алфавиту, то вывести 0; в противном случае вывести номер первого символа строки,нарушающего алфавитный порядок.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    string  s, a;\n    a = char(int(\'a\') - 1) + \"\";\n    cin >> s;\n    for (int i = 0; i < s.size(); ++i) {        \n        if (s[i] >= \'a\' && s[i] <= \'z\')\n            if (s[i] > a[a.size() - 1])\n                a += s[i];\n            else {                \n                cout << i;\n                return 0;\n            }\n    }\n    cout << 0;\n    return 0;\n}";
                        break;
                    case 69:
                        richTextBox1.Text = "Дана строка, содержащая латинские буквы и круглые скобки. Если скобки расставлены правильно (то есть каждой открывающей соответствует одна закрывающая), то вывести число 0. В противном случае вывести или номер позиции, в которой расположена первая ошибочная закрывающая скобка, или, если закрывающих скобок не хватает, число −1.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    string  s, a = \"\";\n    cin >> s;\n    for (int i = 0; i < s.size(); ++i) {        \n        if (s[i] == \'(\')\n            a += s[i];\n        else if (s[i] == \')\') {            \n            if (a[a.size() - 1] == \'(\')\n                a.erase(a.size() - 1);\n            else {                \n                cout << i;\n                return 0;\n            }\n        }\n    }\n    if (a.size())\n        cout << -1;\n    else\n        cout << 0;\n    return 0;\n}";
                        break;
                    case 70:
                        richTextBox1.Text = "Дана строка, содержащая латинские буквы и скобки трех видов: «()», «[]», «{}». Если скобки расставлены правильно (то есть каждой открывающей соответствует закрывающая скобка того же вида), то вывести число 0. В противном случае вывести или номер позиции, в которой расположена первая ошибочная скобка, или, если закрывающих скобок не хватает, число −1.";
                        richTextBox2.Text = "#include <iostream>\nusing namespace std;\nint main()\n{ \n    string s, a = \"\";\n    cin >> s;\n    for (int i = 0; i < s.size(); ++i) {        \n        if (s[i] == \'(\' || s[i] == \'{\' || s[i] == \'[\')\n            a += s[i];\n        else if (s[i] == \')\') {            \n            if (a[a.size() - 1] == \'(\')\n                a.erase(a.size() - 1);\n            else {                \n                cout << i;\n                return 0;\n            }\n        }\n        else if (s[i] == \']\') {            \n            if (a[a.size() - 1] == \'[\')\n                a.erase(a.size() - 1);\n            else {                \n                cout << i;\n                return 0;\n            }\n        }\n        else if (s[i] == \'}\') {            \n            if (a[a.size() - 1] == \'{\')\n                a.erase(a.size() - 1);\n            else {                \n                cout << i;\n                return 0;\n            }\n        }\n    }\n    if (a.size())\n        cout << -1;\n    else\n        cout << 0;\n    return 0;\n}";
                        break;
                    default:
                        richTextBox1.Text = "";
                        richTextBox2.Text = "";
                        break;
                }
            }

            
            /*
            if (comboBox1.SelectedIndex == 13)   // Задачи с File(1-60)
            {
                switch (comboBox2.SelectedIndex + 1)
                {
                    case 1:
                        richTextBox1.Text = "Дана строка S. Если S является допустимым именем файла, то создать пустой файл с этим именем и вывести TRUE. Если файл с именем S создать нельзя, то вывести FALSE.";
                        richTextBox2.Text = "";
                        break;
                    case 2:
                        richTextBox1.Text = "Дано имя файла и целое число N (>1). Создать файл целых чисел с данным именем и записать в него N первых положительных четных чисел (2, 4, ...).";
                        richTextBox2.Text = "";
                        break;
                    case 3:
                        richTextBox1.Text = "Дано имя файла и вещественные числа A и D. Создать файл вещественных чисел с данным именем и записать в него 10 первых членов арифметической прогрессии с начальным членом A и разностью D: A, A + D, A + 2·D, A + 3·D, ...";
                        richTextBox2.Text = "";
                        break;
                    case 4:
                        richTextBox1.Text = "Даны имена четырех файлов. Найти количество файлов с указанными именами, которые имеются в текущем каталоге.";
                        richTextBox2.Text = "";
                        break;
                    case 5:
                        richTextBox1.Text = "Дано имя файла целых чисел. Найти количество элементов, содержащихся в данном файле. Если файла с таким именем не существует, то вывести −1";
                        richTextBox2.Text = "";
                        break;
                    case 6:
                        richTextBox1.Text = "Дано целое число K и файл, содержащий неотрицательные целые числа. Вывести K-й элемент файла (элементы нумеруются от 1). Если такой элемент отсутствует, то вывести −1";
                        richTextBox2.Text = "";
                        break;
                    case 7:
                        richTextBox1.Text = "Дан файл целых чисел, содержащий не менее четырех элементов. Вывестипервый,второй,предпоследнийипоследнийэлементыданногофайла.";
                        richTextBox2.Text = "";
                        break;
                    case 8:
                        richTextBox1.Text = "Даны имена двух файлов вещественных чисел. Известно, что первый из них существует и является непустым, а второй в текущем каталоге отсутствует. Создать отсутствующий файл и записать в него начальный и конечный элементы существующего файла (в указанном порядке).";
                        richTextBox2.Text = "";
                        break;
                    case 9:
                        richTextBox1.Text = "Даны имена двух файлов вещественных чисел. Известно, что один из них (не обязательно первый) существует и является непустым, а другой в текущем каталоге отсутствует. Создать отсутствующий файл и записать в негоконечныйиначальныйэлементысуществующегофайла(вуказанном порядке).";
                        richTextBox2.Text = "";
                        break;
                    case 10:
                        richTextBox1.Text = "Дан файл целых чисел. Создать новый файл, содержащий те же элементы, что и исходный файл, но в обратном порядке.";
                        richTextBox2.Text = "";
                        break;
                    case 11:
                        richTextBox1.Text = "Дан файл вещественных чисел. Создать два новых файла, первый из которых содержит элементы исходного файла с нечетными номерами (1, 3, ...), а второй — с четными (2, 4, ...).";
                        richTextBox2.Text = "";
                        break;
                    case 12:
                        richTextBox1.Text = "Дан файл целых чисел. Создать два новых файла, первый из которых содержитчетныечислаизисходногофайла,авторой—нечетные(втомже порядке).Есличетныеилинечетныечислависходномфайлеотсутствуют, то соответствующий результирующий файл оставить пустым.";
                        richTextBox2.Text = "";
                        break;
                    case 13:
                        richTextBox1.Text = "Дан файл целых чисел. Создать два новых файла, первый из которых содержит положительные числа из исходного файла (в обратном порядке), а второй — отрицательные (также в обратном порядке). Если положительные или отрицательные числа в исходном файле отсутствуют, то соответствующий результирующий файл оставить пустым.";
                        richTextBox2.Text = "";
                        break;
                    case 14:
                        richTextBox1.Text = "Дан файл вещественных чисел. Найти среднее арифметическое его элементов.";
                        richTextBox2.Text = "";
                        break;
                    case 15:
                        richTextBox1.Text = "Дан файл вещественных чисел. Найти сумму его элементов с четными номерами.";
                        richTextBox2.Text = "";
                        break;
                    case 16:
                        richTextBox1.Text = "Дан файл целых чисел. Найти количество содержащихся в нем серий (то есть наборов последовательно расположенных одинаковых элементов). Например, для файла с элементами 1, 5, 5, 5, 4, 4, 5 результат равен 4.";
                        richTextBox2.Text = "";
                        break;
                    case 17:
                        richTextBox1.Text = "Дан файл целых чисел. Создать новый файл целых чисел, содержащий длины всех серий исходного файла (серией называется набор последовательно расположенных одинаковых элементов, а длиной серии — количество этих элементов). Например, для исходного файла с элементами 1, 5, 5,5,4,4,5содержимоерезультирующегофайладолжнобытьследующим: 1, 3, 2, 1.";
                        richTextBox2.Text = "";
                        break;
                    case 18:
                        richTextBox1.Text = "Дан файл вещественных чисел. Найти его первый локальный минимум (локальным минимумом называется элемент, который меньше своих соседей).";
                        richTextBox2.Text = "";
                        break;
                    case 19:
                        richTextBox1.Text = "Данфайлвещественныхчисел.Найтиегопоследнийлокальныймаксимум (локальным максимумом называется элемент, который больше своих соседей).";
                        richTextBox2.Text = "";
                        break;
                    case 20:
                        richTextBox1.Text = "Дан файл вещественных чисел. Найти общее количество его локальных экстремумов, то есть локальных минимумов и локальных максимумов (определения локального минимума и локального максимума даны в заданиях File18 и File19).";
                        richTextBox2.Text = "";
                        break;
                    case 21:
                        richTextBox1.Text = "Дан файл вещественных чисел. Создать файл целых чисел, содержащий номера всех локальных максимумов исходного файла в порядке возрастания (определение локального максимума дано в задании File19).";
                        richTextBox2.Text = "";
                        break;
                    case 22:
                        richTextBox1.Text = "Дан файл вещественных чисел. Создать файл целых чисел, содержащий номера всех локальных экстремумов исходного файла в порядке убывания (определение локального экстремума дано в задании File20).";
                        richTextBox2.Text = "";
                        break;
                    case 23:
                        richTextBox1.Text = "Дан файл вещественных чисел. Создать файл целых чисел, содержащий длины всех убывающих последовательностей элементов исходного файла. Например, для исходного файла с элементами 1.7, 4.5, 3.4, 2.2, 8.5, 1.2 содержимое результирующего файла должно быть следующим: 3, 2.";
                        richTextBox2.Text = "";
                        break;
                    case 24:
                        richTextBox1.Text = "Дан файл вещественных чисел. Создать файл целых чисел, содержащий длины всех монотонных последовательностей элементов исходного файла. Например, для исходного файла с элементами 1.7, 4.5, 3.4, 2.2, 8.5, 1.2 содержимое результирующего файла должно быть следующим: 2, 3, 2, 2.";
                        richTextBox2.Text = "";
                        break;
                    case 25:
                        richTextBox1.Text = "Дан файл вещественных чисел. Заменить в нем все элементы на их квадраты.";
                        richTextBox2.Text = "";
                        break;
                    case 26:
                        richTextBox1.Text = "Дан файл вещественных чисел. Поменять в нем местами минимальный и максимальный элементы.";
                        richTextBox2.Text = "";
                        break;
                    case 27:
                        richTextBox1.Text = "Дан файл целых чисел с элементами A1, A2, ..., AN (N — количество элементов в файле). Заменить исходное расположение его элементов на следующее: A1, AN, A2, AN−1, A3, ... .";
                        richTextBox2.Text = "";
                        break;
                    case 28:
                        richTextBox1.Text = "Дан файл вещественных чисел.Заменить в файле каждый элемент,кроме начального и конечного, на его среднее арифметическое с предыдущим и последующим элементом.";
                        richTextBox2.Text = "";
                        break;
                    case 29:
                        richTextBox1.Text = "Дан файл целых чисел, содержащий более 50 элементов. Уменьшить его размер до 50 элементов, удалив из файла необходимое количество конечных элементов.";
                        richTextBox2.Text = "";
                        break;
                    case 30:
                        richTextBox1.Text = "Дан файл целых чисел, содержащий четное количество элементов. Удалить из данного файла вторую половину элементов.";
                        richTextBox2.Text = "";
                        break;
                    case 31:
                        richTextBox1.Text = "Дан файл целых чисел, содержащий более 50 элементов. Уменьшить его размер до 50 элементов, удалив из файла необходимое количество начальных элементов.";
                        richTextBox2.Text = "";
                        break;
                    case 32:
                        richTextBox1.Text = "Дан файл целых чисел, содержащий четное количество элементов. Удалить из данного файла первую половину элементов.";
                        richTextBox2.Text = "";
                        break;
                    case 33:
                        richTextBox1.Text = "Дан файл целых чисел. Удалить из него все элементы с четными номерами.";
                        richTextBox2.Text = "";
                        break;
                    case 34:
                        richTextBox1.Text = "Дан файл целых чисел. Удалить из него все отрицательные числа";
                        richTextBox2.Text = "";
                        break;
                    case 35:
                        richTextBox1.Text = "Дан файл целых чисел, содержащий менее 50 элементов. Увеличитьего размер до 50 элементов, записав в начало файла необходимое количество нулей.";
                        richTextBox2.Text = "";
                        break;
                    case 36:
                        richTextBox1.Text = "Дан файл целых чисел. Удвоить его размер, записав в конец файла все его исходные элементы (в том же порядке).";
                        richTextBox2.Text = "";
                        break;
                    case 37:
                        richTextBox1.Text = "Дан файл целых чисел. Удвоить его размер, записав в конец файла все его исходные элементы (в обратном порядке).";
                        richTextBox2.Text = "";
                        break;
                    case 38:
                        richTextBox1.Text = "Дан файл целых чисел. Продублировать в нем все элементы с нечетными номерами.";
                        richTextBox2.Text = "";
                        break;
                    case 39:
                        richTextBox1.Text = "Дан файл целых чисел. Продублировать в нем все числа, принадлежащие диапазону 5–10.";
                        richTextBox2.Text = "";
                        break;
                    case 40:
                        richTextBox1.Text = "Дан файл целых чисел. Заменить в нем каждый элемент с четным номером на два нуля.";
                        richTextBox2.Text = "";
                        break;
                    case 41:
                        richTextBox1.Text = "Дан файл целых чисел. Заменить в нем каждое положительное число на три нуля.";
                        richTextBox2.Text = "";
                        break;
                    case 42:
                        richTextBox1.Text = "Даны два файла произвольного типа. Поменять местами их содержимое.";
                        richTextBox2.Text = "";
                        break;
                    case 43:
                        richTextBox1.Text = "Дан файл произвольного типа. Создать его копию с новым именем.";
                        richTextBox2.Text = "";
                        break;
                    case 44:
                        richTextBox1.Text = "Даны три файла одного и того же типа, но разного размера. Заменить содержимое самого длинного файла на содержимое самого короткого.";
                        richTextBox2.Text = "";
                        break;
                    case 45:
                        richTextBox1.Text = "Даны три файла одного и того же типа, но разного размера. Заменить содержимое самого короткого файла на содержимое самого длинного.";
                        richTextBox2.Text = "";
                        break;
                    case 46:
                        richTextBox1.Text = "Дана строка S0, целое число N (≤4) и N файлов одного и того же типа с именами S1, ..., SN. Объединить содержимое этих файлов (в указанном порядке) в новом файле с именем S0.";
                        richTextBox2.Text = "";
                        break;
                    case 47:
                        richTextBox1.Text = "Даны два файла одного и того же типа. Добавить к первому файлу содержимое второго файла, а ко второму файлу — содержимое первого.";
                        richTextBox2.Text = "";
                        break;
                    case 48:
                        richTextBox1.Text = "Даны три файла целых чисел одинакового размера с именами SA, SB, SC и строка SD. Создать новый файл с именем SD, в котором чередовались бы элементы исходных файлов с одним и тем же номером: A1, B1, C1, A2, B2, C2, ... .";
                        richTextBox2.Text = "";
                        break;
                    case 49:
                        richTextBox1.Text = "Даны четыре файла целых чисел разного размера с именами SA, SB, SC, SD и строка SE. Создать новый файл с именем SE, в котором чередовались бы элементы исходных файлов с одним и тем же номером (как в задании File48). «Лишние» элементы более длинных файлов в результирующий файл не записывать.";
                        richTextBox2.Text = "";
                        break;
                    case 50:
                        richTextBox1.Text = "Даны два файла вещественных чисел с именами S1 и S2, элементы которыхупорядоченыповозрастанию.Объединитьэтифайлывновыйфайл с именем S3 так, чтобы его элементы также оказались упорядоченными по возрастанию.";
                        richTextBox2.Text = "";
                        break;
                    case 51:
                        richTextBox1.Text = "Даны три файла вещественных чисел с именами S1, S2 и S3, элементы которых упорядочены по убыванию. Объединить эти файлы в новый файл с именем S4 так, чтобы его элементы также оказались упорядоченными по убыванию.";
                        richTextBox2.Text = "";
                        break;
                    case 52:
                        richTextBox1.Text = "Дана строка S0,целое числоN (≤4) и N файлов целых чисел с именами S1, ..., SN. Объединить их содержимое в новом файле-архиве с именем S0, используя следующий формат: в первом элементе файла-архива хранится число N, в следующих N элементах хранится размер (число элементов) каждого из исходных файлов, а затем последовательно размещаются данные из каждого исходного файла.";
                        richTextBox2.Text = "";
                        break;
                    case 53:
                        richTextBox1.Text = "Дана строка S, целое число N (>0) и файл-архив целых чисел, содержащий данные из нескольких файлов в формате, описанном в задании File52. Восстановить из файла-архива файл с номером N и сохранить его под именем S. Если файл-архив содержит данные из менее чем N файлов, то оставить результирующий файл пустым.";
                        richTextBox2.Text = "";
                        break;
                    case 54:
                        richTextBox1.Text = "Дана строка S и файл-архив целых чисел, содержащий данные из нескольких (не более шести) файлов в формате, описанном в задании File52. Для каждого из файлов, содержащихся в архиве, найти среднее арифметическое всех его элементов (вещественное число) и записать найденные числа (в том же порядке) в файл вещественных чисел с именем S.";
                        richTextBox2.Text = "";
                        break;
                    case 55:
                        richTextBox1.Text = "Дана строка s0, целое число N (≤4) и N файлов целых чисел с именами s1, ..., sn. Объединить их содержимое в новом файле-архиве с именем s0, последовательно записывая в него следующие данные: размер (число элементов) первого исходного файла и все элементы этого файла, размер второго исходного файла и все его элементы, ..., размер N-го исходного файла и все его элементы.";
                        richTextBox2.Text = "";
                        break;
                    case 56:
                        richTextBox1.Text = "Дана строка S, целое число N (>0) и файл-архив целых чисел, содержащий данные из нескольких файлов в формате, описанном в задании File55. Восстановить из файла-архива файл с номером N и сохранить его под именем S. Если файл-архив содержит данные из менее чем N файлов, то оставить результирующий файл пустым.";
                        richTextBox2.Text = "";
                        break;
                    case 57:
                        richTextBox1.Text = "Даны строки S1, S2 и файл-архив целых чисел, содержащий данные из нескольких файлов в формате, описанном в задании File55. Создать новые файлы целых чисел с именами S1 и S2 и записать в первый из них начальные элементы всех файлов, содержащихся в архиве, а во второй — конечные элементы этих файлов (в том же порядке).";
                        richTextBox2.Text = "";
                        break;
                    case 58:
                        richTextBox1.Text = "Дан символьный файл, содержащий по крайней мере один символ пробела. Удалить все его элементы, расположенные после первого символа пробела, включая и этот пробел.";
                        richTextBox2.Text = "";
                        break;
                    case 59:
                        richTextBox1.Text = "Дан символьный файл, содержащий по крайней мере один символ пробела. Удалить все его элементы, расположенные после последнего символа пробела, включая и этот пробел.";
                        richTextBox2.Text = "";
                        break;
                    case 60:
                        richTextBox1.Text = "Дан символьный файл, содержащий по крайней мере один символ пробела. Удалить все его элементы, расположенные перед первым символом пробела, включая и этот пробел.";
                        richTextBox2.Text = "";
                        break;
                    default:
                        richTextBox1.Text = "";
                        richTextBox2.Text = "";
                        break;
                }
            
            }
            */
        }
            
        private void Form1_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(800, 500);
            //FormBorderStyle = FormBorderStyle.FixedSingle;
        }

        private void richTextBox1_TextChanged(object sender, EventArgs e)
        {


        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://qiwi.com/n/PASEE515");
        }

        private void linkLabel2_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Process.Start("https://t.me/+b9_LchnHXBw1NTMx");
        }

        private void label5_Click(object sender, EventArgs e)
        {

        }
    }
}
