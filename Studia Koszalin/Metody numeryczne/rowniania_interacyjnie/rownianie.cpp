#include<iostream>
#include<fstream>

using namespace std;

int main(){
	double x[10];
	double maca[10][10];
	double wek[10];
	fstream macierz;
	fstream wektor;
	fstream wynik;
	macierz.open("macierz.txt",ios::in);
	wektor.open("wektor.txt",ios::in);
	wynik.open("wynik.txt",ios::out);
	
	if(macierz.good()==true && wektor.good()==true && wynik.good()==true){
		cout<<"Uzyskano dostep"<<endl;
			int N;
			macierz>>N;
			cout<<"Wspolczynniki przy kolejnych zmiennych ukladu rownan";
			for(int i=0;i<N;i++){
				cout<<endl;
				for(int j=0;j<N;j++){
					macierz>>maca[i][j];
					cout<<maca[i][j];
					cout<<" ";
				}
			}
			cout<<endl;
			cout<<"Wyrazy wolne";
				for(int j=0;j<N;j++){
					cout<<endl;
					wektor>>wek[j];
					if(wek[j]>0) 
					cout<<" ";
					cout<<wek[j];
				}
			cout<<endl;
			
		for(int k=0;k<200;k++){
			for(int i=0;i<N;i++){
				x[i]=0;
				for(int j=0;j<N;j++){
					if(i==j){
						x[i]=x[i]+(wek[i]/maca[i][i]);
					}
					else
						{
						x[i]=x[i]-((maca[i][j]/maca[i][i])*x[j]);
						}
				}
			}
		}
		cout<<endl;
		cout<<"Rozwiazaniami tego rowniania sa liczby:";
		wynik<<"Rozwiazaniami tego rowniania sa liczby: ";
			for(int i=0;i<N;i++){
				cout<<x[i];
				cout<<",";
				wynik<<x[i];
				wynik<<",";
			}
	}
	return 0;
}
