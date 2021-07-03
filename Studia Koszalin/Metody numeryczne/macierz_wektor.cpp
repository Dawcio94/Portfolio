#include<iostream>
#include<fstream>


using namespace std;
	fstream macierz;
	macierz.open("macierz.txt",ios::in);

	

int main(){
	
	double mac[10][10];
	int licznik=0;
	double wek[10][10];
	double macw[10][10];

	fstream wektor;
	fstream wynik;
	wektor.open("wektor.txt",ios::in);
	wynik.open("wynik.txt",ios::out);
	cout<<"*************************Mnozenie macierzy przez wektor*************************";
	if(macierz.good()==true && wektor.good()==true && wynik.good()==true){
		cout<<"Uzyskano dostep"<<endl;
		int N;
		int L;
		macierz>>N;
		macierz>>L;
		for(int i=0;i<N;i++){
			for(int j=0;j<N;j++){
				macierz>>mac[i][j];
		}
	}
	for(int i=0;i<1;i++){
			for(int j=0;j<N;j++){
				wektor>>wek[i][j];
}}
wynik<<"Wynik mnozenia to:"<<endl;
//macw[0][0]=0;
//wynik<<macw[0][0];
for(int i=0;i<N;i++){
	wynik<<endl;
		int suma=0;
			for(int p=0;p<i;p++){	
			suma += mac[i][p]*wek[0][p];
			licznik=licznik+1;
			macw[i][0] = suma;
			cout<<mac[i][p]<<" "<<wek[0][p]<<" "<<endl; 
			
		}wynik<<macw[i][0]<<" ";
		
	}}else{
		cout<<"Brak dostepu"<<endl;
	}
	cout<<endl;
	cout<<licznik;
return 0;
}
