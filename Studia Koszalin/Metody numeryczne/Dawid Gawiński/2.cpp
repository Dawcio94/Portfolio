#include <iostream>
#include <fstream>

using namespace std;

int main(){
	int A[100][100], W[100], AW[100], l, n, s, licznik, granica;
	fstream plik, plik2;
	
	plik.open("dane.txt", ios::in);
	plik2.open("wynik.txt", ios::out);
	
	if(plik.good()==false || plik2.good()==false){
		cout<<"nie uda³o siê odczytaæ pliku!";
		return 0;
	}
	plik>>n;
	plik>>l;
	if(l>n){
		cout<<"Blad"<<endl;
		return 0;
	}
	if(n%l==0){
	
	
	for(int i=0; i<n; i++){
		for(int j=0;j<n; j++){
		plik>>A[j][i];
		}
	}

	
	for(int i=0; i<n; i++){
		plik>>W[i];
}
		
		licznik=0;
		granica=1;
		
		for(int i=0; i<n; i++){
			if(granica<=n){
			s=0;
								for(int j=0; j<granica; j++){
								
									if(j%(l*2)<l){
									s+=A[j][i]*W[j];
									AW[i] = s;
									licznik++;
									cout<<s;}
								}
			granica+=1;		
			}
		
		}

		for(int i=0; i<n; i++){
		plik2<<AW[i]<<endl;
		}
	plik2<<"Licznik:"<<licznik<<endl;	
	}

else{
	cout<<"Blad"<<endl;
	return 0;
}	
	
plik.close();
plik2.close();
}
