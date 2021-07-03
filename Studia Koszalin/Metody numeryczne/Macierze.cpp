#include<iostream>
#include<math.h>
#include<conio.h>
#include<fstream>

using namespace std;

int main(){
	int i,j,w_a,k_w,k_b;
	double macc[10][10];
	double maca[10][10];
	double macb[10][10];
	fstream macierzA;
	fstream macierzB;
	fstream macierzC;
	macierzA.open("MacierzA.txt", ios::in);
	macierzB.open("MacierzB.txt",ios::in);
	macierzC.open("MacierzC.txt",ios::out);
	cout<<"*******************************Mnozenie macierzy!!!*****************************";

if(macierzA.good()==true){
	cout<<"Uzyskano dostep"<<endl;
	macierzA>>w_a;
	macierzA>>k_w;
	cout<<"Macierz A";
	for(i=0;i<w_a;i++){
		cout<<endl;
		for(j=0;j<k_w;j++){
			macierzA>>maca[i][j];
			cout<<maca[i][j]<<" ";
		}
	}
	cout<<endl;
	}
if(macierzB.good()==true){
	cout<<"Uzyskano dostep"<<endl;
	macierzB>>k_b;
	macierzB>>k_w;
	cout<<"Macierz B";
	for(i=0;i<k_w;i++){
		cout<<endl;
		for(j=0;j<k_b;j++){
			macierzB>>macb[i][j];
			cout<<macb[i][j]<<" ";
		}
	}
	cout<<endl;
	}

if(macierzC.good()==true){
	int p;
	cout<<"Uzyskano dostep";
	macierzC<<"Macierz C";
	
for(i=0;i<w_a;i++){
	cout<<endl;
	for(j=0;j<k_b;j++){
		int suma=0;
			for(p=0;p<k_w;p++){	
			suma += maca[i][p] * macb[p][j];
			macc[i][j] = suma;
			
			}cout<<macc[i][j]<<" ";
			
		}
	}
}
	return 0;
}
