#include <iostream> 
#include <string> 
using namespace std; 
int product(int x, int n) { 
    //произведение первых N чисел числа X 
} 
 
int enter_number_n() { 
    //ввод числа N
} 
 
int enter_number_x() { 
    //ввод числа X; 
} 
 
int sum_digits(int x) { 
    //вычисление суммы цифр числа X 
} 
 
int main() { 
    int en = 0, ix = 0, prod = 0, suma = 0; 
    while (true) { 
        std::cout << "1. ввести натуральное число X\n2. ввести цифру N (которая меньше числа разрядов числа X)\n3. определить произведение первых N цифр натурального числа X\n4. определить сумму цифр введенного числа X\n\nВведите номер желаемой функции или 0, если хотите закрыть приложение."; 
        int key; 
        std::cin >> key; 
        if (key == 0) { 
            break; 
        } 
        if (key == 1) { 
            ix = enter_number_x(); 
        } else if (key == 2) { 
            en = enter_number_n(); 
        } else if (key == 3) { 
            prod = product(ix, en); 
            std::cout << "Произведение: " << prod << std::endl; 
        } else if (key == 4) { 
            suma = sum_digits(ix); 
            std::cout << "Сумма: " << suma << std::endl; 
        } 
    } 
    return 0; 
}