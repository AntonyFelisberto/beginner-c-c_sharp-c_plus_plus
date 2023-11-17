// LearningC++.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
#include <iomanip>
#include <string>
#include <vector>

using namespace std;

int main()
{
    std::cout << "Hello World!\n";

    int idade;
    double salario;
    char genero;
    string nome;

    idade = 20;
    salario = 5888.4;
    genero = 'F';
    nome = "ESTE NOME";
    
    int x, y;

    x = 10;
    y = 2;

    cout << x << endl;
    cout << y << endl;

    cout << fixed << setprecision(2);
    cout << "IDADE " << idade << endl;
    cout << "SALARIO " << salario << endl;
    cout << "GENERO " << genero << endl;
    cout << "NOME " << nome << endl;

    cout << "O << SERVE COMO CONCATENACAO DE PARAMETROS JA O >> SERVE PARA ATRIBUICAO" << " ATE O FIM" << endl;
    
    double resultado;
    resultado = x / y;

    cout << resultado << endl;
    cout << (int)resultado << endl;

    cout << fixed << setprecision(2) << x << endl;

    string nomeCompleto;
    cout << "digite o nome completo" << endl;
    cin >> nomeCompleto;
    cout << nomeCompleto << endl;

    cout << "digite o nome completo" << endl;
    cin.ignore(INT_MAX, '\n');
    getline(cin,nomeCompleto);
    cout << nomeCompleto << endl;
    cout << "digite o salario: ";
    cin >> salario;

    cout << sqrt(pow(1, 2.5)) << endl;

    cout << "digite dois numeros: ";
    cin >> x >> y;

    if (salario == 0) {
        cout << "voce ta mal" << endl;
    }
    else if (salario >= 1000) {
        cout << "voce ta vivendo bem" << endl;
    }
    else
    {
        cout << "voce ta meio mal" << endl;
    }

    for (int i = 0; i < idade;i++) {
        cout << i << endl;
    }

    int N;
    
    cout << "numero de pessoas: ";
    cin >> N;

    vector<string> nomes(N);
    vector<int> idades(N);
    vector<double> altura(N);

    for (int i = 0; i < N; i++) {
        cout << "digite o nome da pessoa" << endl;
        cin.ignore(INT_MAX, '\n');
        getline(cin,nomes[i]);
        cout << "digite o idades da pessoa" << endl;
        cin >> idades[i];
        cout << "digite o numero da altura" << endl;
        cin >> altura[i];
    }

    for (int i = 0; i < N; i++) {
        cout <<"nomes: "<< nomes[i] << " idades: "<< idades[i] <<" altura: " << (double) altura[i] << endl;
    }

    int i, j;

    cout << "numero da linha: ";
    cin >> i;

    cout << "numero da coluna: ";
    cin >> j;

    // Dynamically allocate memory for the 2D array
    int** matriz = new int* [i];
    for (int row = 0; row < i; ++row) {
        matriz[row] = new int[j];
    }

    // Now you can use matriz as a 2D array

    // Don't forget to free the allocated memory when you're done
    for (int row = 0; row < i; ++row) {
        delete[] matriz[row];
    }
    delete[] matriz;


    return 0;

    return 0;
}

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
