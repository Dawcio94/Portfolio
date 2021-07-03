#include <fstream>
#include <iostream>
#include <stdio.h>
#include <stdlib.h>
#include <cstdlib>
#include <string>
#include <math.h>
#include "allegro5/allegro.h"
#include "allegro5/allegro_image.h"
#include "allegro5/allegro_primitives.h"
#include "allegro5/allegro_font.h"
#include "allegro5/allegro_ttf.h" 
#include <allegro5/allegro_audio.h>
#include <allegro5/allegro_acodec.h>

std::fstream high("wyniki.txt", std::ios::in | std::ios::out);
std::string name1,name2,name3;
int score1,score2,score3;
std::string wynik1, wynik2, wynik3;

void read_high() {
		    high >> name1 >> score1 >> name2 >> score2 >> name3 >> score3; 
		    //wynik1 = name1+" : "+score1;
		    //wynik2 = name2+" : "+score2;
		    //wynik3 = name3+" : "+score3;
};

class Hero {
	
	public: 
	int rozm=40;
	int x=310,y=400;
	
	int energy = 100;
	double czas_energy = al_get_time();
	double czas_shoot_hero=al_get_time();
	int counter_shoot = 0;
	int num_of_shoot = 15;
	int shoot_h[15][2] {
		{-1, -1},
		{-1, -1},
		{-1, -1},
		{-1, -1},
		{-1, -1},
		{-1, -1},
		{-1, -1},
		{-1, -1},
		{-1, -1},
		{-1, -1},
		{-1, -1},
		{-1, -1},
		{-1, -1},
		{-1, -1},
		{-1, -1},
	};
	
	void clear_shoot_hero() {
		for (int i = 0; i<num_of_shoot; ++i) {
		shoot_h[i][0] = -1;
		shoot_h[i][1] = -1;
		}
	}
	
	void shoot_hero() {
		if ( al_get_time() > czas_shoot_hero + 0.05) {
			shoot_h[counter_shoot][0] = x + 20; 
			shoot_h[counter_shoot][1] = y + 10; 
			counter_shoot++; 
		}
		czas_shoot_hero = al_get_time();
		if (counter_shoot == num_of_shoot)
		counter_shoot = 0; 
	};
	
	void show_shoot_hero() {
		for(int i = 0; i < num_of_shoot; ++i) {
			if (shoot_h[i][1] == -10)
				continue;
				
			shoot_h[i][1] = shoot_h[i][1] - 1;	
		}
	};
};

class Enemy {
	
	public:
	int lvl = 0; 
	int num_of_enemy = 9;
	int enemy_position[9][3] =  { //pozycja enemy [nr][0] - poz X, [nr][1] - poz Y, [nr][2] - poz max X
			{30,  40, 50},
			{90,  40, 110},
			{150, 40, 170},
			{210, 40, 230},
			{270, 40, 290},
			{330, 40, 350},
			{390, 40, 410},
			{450, 40, 470},
			{510, 40, 530},
	};
		
		int enemy_position_start_level1[9][3] =  { //pozycja enemy [nr][0] - poz X, [nr][1] - poz Y, [nr][2] - poz max X
			{30,  40, 50},
			{90,  40, 110},
			{150, 40, 170},
			{210, 40, 230},
			{270, 40, 290},
			{330, 40, 350},
			{390, 40, 410},
			{450, 40, 470},
			{510, 40, 530},
		};
		
		int enemy_position_start_level2[9][3] = {
			{30,  40, 50},
			{90,  60, 110},
			{150, 80, 170},
			{210, 100, 230},
			{270, 120, 290},
			{330, 100, 350},
			{390, 80, 410},
			{450, 60, 470},
			{510, 40, 530},
		};
		
		int enemy_position_start_level3[9][3] = {
			{30,  40, 50},
			{90,  80, 110},
			{150, 40, 170},
			{210, 80, 230},
			{270, 40, 290},
			{330, 80, 350},
			{390, 40, 410},
			{450, 80, 470},
			{510, 40, 530},
		};
		
		int enemy_position_start_level4[9][3] = {
			{30,  40, 50},
			{30,  80, 50},
			{150, 40, 170},
			{150, 80, 170},
			{330, 40, 350},
			{330, 80, 350},
			{450, 40, 470},
			{450, 80, 470},
			{240, 60, 260},
		};
		
		int enemy_position_start_level5[9][3] = {
			{210, 40, 230},
			{270, 40, 290},
			{330, 40, 350},
			{210, 80, 230},
			{270, 80, 290},
			{330, 80, 350},
			{210, 120, 230},
			{270, 120, 290},
			{330, 120, 350},
		};
		
		int enemy_position_start_level6[9][3] = {
			{210, 40, 230},
			{270, 40, 290},
			{330, 40, 350},
			{390, 40, 410},
			{240, 80, 260},
			{300, 80, 320},
			{360, 80, 380},
			{270, 120, 290},
			{330, 120, 350},
		};
		
		int enemy_position_start_level7[9][3] = {
			{270,  40, 290},
			{210,  80, 230},
			{330, 80, 350},
			{150, 100, 170},
			{270, 100, 290},
			{390, 100, 410},
			{210, 120, 230},
			{330, 120, 350},
			{270, 160, 290},
		};
	

	int counter_generate_enemy = 0; 
	double czas_enemy=al_get_time();
	double czas_shoot_enemy=al_get_time();
	int flaga_enemy = 0;
	int num_of_shoot_enemy = 216;
	int shoot_e[216][2];
	int counter_shoot_enemy = 0;
	int los = 0;
	
	void clear_shoot_enemy() {
		for (int i = 0; i<num_of_shoot_enemy; ++i) {
		shoot_e[i][0] = -1;
		shoot_e[i][1] = -1;
	}
	
	}
	int generate_enemy(){  	
		int flaga = 0;
		
			for(int i=0;i<num_of_enemy;++i){
    			if(enemy_position[i][0]>0 ){
    			flaga = 1; 
    			}
    		}	
    	/*for(int i=0; i<num_of_shoot;++i){
    	shoot_h[i][0]=-1;
    	shoot_h[i][1]=-1;
    	}*/
    		if (flaga == 0) {
    			if (lvl%7 == 0) {
    				for(int i=0;i<num_of_enemy;++i) {
			    		enemy_position[i][0] = enemy_position_start_level1[i][0];
			    		enemy_position[i][1] = enemy_position_start_level1[i][1];
			    		enemy_position[i][2] = enemy_position_start_level1[i][2];
			    		al_flip_display();
					};
				};
			
				if (lvl%7 == 1) {
    				for(int i=0;i<num_of_enemy;++i) {
			    		enemy_position[i][0] = enemy_position_start_level2[i][0];
			    		enemy_position[i][1] = enemy_position_start_level2[i][1];
			    		enemy_position[i][2] = enemy_position_start_level2[i][2];
			    		al_flip_display();
					};
				};
				
				if (lvl%7 == 2) {
    				for(int i=0;i<num_of_enemy;++i) {
			    		enemy_position[i][0] = enemy_position_start_level7[i][0];
			    		enemy_position[i][1] = enemy_position_start_level7[i][1];
			    		enemy_position[i][2] = enemy_position_start_level7[i][2];
			    		al_flip_display();
					};
				};
				
				if (lvl%7 == 3) {
    				for(int i=0;i<num_of_enemy;++i) {
			    		enemy_position[i][0] = enemy_position_start_level3[i][0];
			    		enemy_position[i][1] = enemy_position_start_level3[i][1];
			    		enemy_position[i][2] = enemy_position_start_level3[i][2];
			    		al_flip_display();
					};
				};
				
				if (lvl%7 == 4) {
    				for(int i=0;i<num_of_enemy;++i) {
			    		enemy_position[i][0] = enemy_position_start_level4[i][0];
			    		enemy_position[i][1] = enemy_position_start_level4[i][1];
			    		enemy_position[i][2] = enemy_position_start_level4[i][2];
			    		al_flip_display();
					};
				};
				
				if (lvl%7 == 5) {
    				for(int i=0;i<num_of_enemy;++i) {
			    		enemy_position[i][0] = enemy_position_start_level5[i][0];
			    		enemy_position[i][1] = enemy_position_start_level5[i][1];
			    		enemy_position[i][2] = enemy_position_start_level5[i][2];
			    		al_flip_display();
					};
				};
				
				if (lvl%7 == 6) {
    				for(int i=0;i<num_of_enemy;++i) {
			    		enemy_position[i][0] = enemy_position_start_level6[i][0];
			    		enemy_position[i][1] = enemy_position_start_level6[i][1];
			    		enemy_position[i][2] = enemy_position_start_level6[i][2];
			    		al_flip_display();
					};
				};
				
			return 1; 
    		}
    };
	
	void move_enemy() {
		if ( al_get_time() > czas_enemy + 0.05) {
			for (int i = 0; i<num_of_enemy; ++i) {
				if (enemy_position[i][0] < enemy_position[i][2] && flaga_enemy == 0) {
					enemy_position[i][0] = enemy_position[i][0] + 1;
						if (enemy_position[i][0]  == enemy_position[i][2] ) flaga_enemy = 180; 
				}
            	else {
            		enemy_position[i][0] = enemy_position[i][0] - 1;
            		flaga_enemy-- ;
        		}
			};
        	czas_enemy = al_get_time();

   		};
	
	};
	
	void shoot_enemy() {
		los = (std::rand() % 9);
		if ( al_get_time() > czas_shoot_enemy + 0.009-(lvl*0.001)) {
			shoot_e[counter_shoot_enemy][0] = enemy_position[los][0] + 20;
			shoot_e[counter_shoot_enemy][1] = enemy_position[los][1] + 10; 
			counter_shoot_enemy++; 
		}
		czas_shoot_enemy = al_get_time();
		if (counter_shoot_enemy == 100)
		counter_shoot_enemy = 0;
	};
	
	void show_shoot_enemy() {
		for(int i = 0; i < num_of_shoot_enemy; ++i) {
			if (shoot_e[i][1] == 500)
				continue;
			shoot_e[i][1] = shoot_e[i][1] + 1;	
		}
	};
	
};


class World : public Enemy, public Hero {
	
	public:
	int skin=0;
	int wynik = 0;
	int szer=640, wys=480;
	double czas=al_get_time();
	ALLEGRO_FONT *test = al_create_builtin_font();

		

	
	void start_game() {        
		ALLEGRO_KEYBOARD_STATE klawiatura;
		ALLEGRO_BITMAP *mapa = al_load_bitmap("space.jpg");
    	ALLEGRO_BITMAP *hero=al_load_bitmap("spaceship.png");
    	ALLEGRO_BITMAP *bullet=al_load_bitmap("bullet.png");
    	ALLEGRO_BITMAP *bullet_enemy=al_load_bitmap("bullet_e.png");
    	ALLEGRO_BITMAP *enemy=al_load_bitmap("enemy.png");
    	ALLEGRO_FONT *score = al_create_builtin_font();
    //	ALLEGRO_SAMPLE *sound_hero = al_load_sample("shoot_h.wav");
    //	ALLEGRO_SAMPLE *destroy_enemy = al_load_sample("enemydead.wav");
    //	ALLEGRO_SAMPLE *new_enemy = al_load_sample("generate_enemy.wav");
    	ALLEGRO_BITMAP *retro_hero=al_load_bitmap("spaceship2.png");
    	ALLEGRO_BITMAP *retro_background=al_load_bitmap("space2.jpg");
    	ALLEGRO_BITMAP *retro_enemy=al_load_bitmap("enemy2.png");
    //	ALLEGRO_SAMPLE *gameover = al_load_sample("Gameover.wav");
        al_reserve_samples(1);
        
		clear_shoot_enemy();
			while(1==1) {
        		al_get_keyboard_state(&klawiatura);
        			if ( al_get_time() > czas + 0.00005) {
            			if ( al_key_down(&klawiatura, ALLEGRO_KEY_RIGHT ) && x < szer-rozm) {
							x=x+1 ; wynik++; //shoot_enemy();
						};
			            
						if ( al_key_down(&klawiatura, ALLEGRO_KEY_LEFT  ) && x > 0) {
							x=x-1 ; wynik++; //shoot_enemy();
						};
			            
						if ( al_key_down(&klawiatura, ALLEGRO_KEY_DOWN  ) && y < wys - rozm) {
							y=y+1 ; wynik++; 
						};
			            
						if ( al_key_down(&klawiatura, ALLEGRO_KEY_UP    ) && y > 0) {
							y=y-1 ; wynik++;
						};
			            
						
						if ( al_key_down(&klawiatura, ALLEGRO_KEY_SPACE  )) {
							shoot_hero();
							shoot_enemy();
							al_play_sample(sound_hero, 8.0, 0.0, 1.0, ALLEGRO_PLAYMODE_ONCE, 0 );
							
						};

			            if(al_key_down(&klawiatura, ALLEGRO_KEY_ESCAPE)) {
			            	al_rest(0.1);
			            		for (int i=0; i<1000; ++i) {
									if (generate_menu() == 0)
									break;
								
								}
						};
        	
        			move_enemy();
        			
        			show_shoot_hero();
        			
					show_shoot_enemy();
					if(energy<1){
						al_play_sample(gameover, 8.0, 0.0, 1.0, ALLEGRO_PLAYMODE_ONCE, 0 );
						end_game();
					}
					check_shoot_hero();
					
					if(check_shoot_hero() == 123){
					al_play_sample(destroy_enemy, 8.0, 0.0, 4.0, ALLEGRO_PLAYMODE_ONCE, 0 );	
					}
					
					check_level();
					
					if (generate_enemy() == 1) {
						clear_shoot_hero();
						al_rest(0.5);
						al_play_sample(new_enemy, 8.0, 0.0, 1.5, ALLEGRO_PLAYMODE_ONCE, 0 );
					}
					
					

		            czas = al_get_time();
        			}
        			check_shoot_enemy();
										
        		if(skin==0){
        		al_draw_bitmap(retro_background,0,0,0);
		        al_draw_bitmap(retro_hero,x,y,0);
				
				}
				else{
				al_draw_bitmap(mapa,0,0,0);
		        al_draw_bitmap(hero,x,y,0);
				}
				al_draw_textf(score,al_map_rgb(242,229,195), 10, 10, 0,"Level: %3d", lvl+1);
		    	
				al_draw_textf(score,al_map_rgb(242,229,195), 540, 10,0,"SCORE:%3d",wynik/500);
 			    
				al_draw_textf(score,al_map_rgb(242,229,195), 430, 450,0,"Energia:");
 			    for(int i = 0; i<energy; i++)
 			    	al_draw_textf(score,al_map_rgb(242,229,195), 500+i, 450,0,"I");
    		
				for (int i = 0; i<num_of_enemy; ++i) {
       				if (skin==1)
					   al_draw_bitmap (enemy,enemy_position[i][0],enemy_position[i][1],0);
					else
						al_draw_bitmap (retro_enemy,enemy_position[i][0],enemy_position[i][1],0);
				   }
       			
       			for (int i = 0; i<num_of_shoot; ++i)
       				al_draw_bitmap (bullet,shoot_h[i][0],shoot_h[i][1],0);
       			for (int i = 0; i<num_of_shoot_enemy; ++i)	
       				al_draw_bitmap (bullet_enemy,shoot_e[i][0],shoot_e[i][1],0);
	   
	   			al_flip_display();
     
     
 			}
	};
	
	
	void generate_world(){

	    ALLEGRO_DISPLAY *okno = al_create_display( 640, 480);
	    al_set_window_title( okno,"Space Impact");
	    ALLEGRO_BITMAP *mapa = al_load_bitmap("space.jpg");
	    al_draw_bitmap (mapa,0,0,0);
	    al_flip_display();
	    generate_menu();
	};

	int generate_menu() {
	
	int menu=0;
	ALLEGRO_KEYBOARD_STATE klawiatura;
	ALLEGRO_FONT *napis = al_load_ttf_font("czcionka.ttf",60, 0);
	ALLEGRO_FONT *font_ttf_30 = al_load_ttf_font("czcionka.ttf",20, 0);
		while(!al_key_down(&klawiatura , ALLEGRO_KEY_ESCAPE)) {
        	al_get_keyboard_state(&klawiatura);
			al_draw_text (napis,al_map_rgb(84,43, 49), 150, 0,0,"Space Impact");
        	al_flip_display();
        
			if(al_get_time() >  czas + 0.05) {
        		if( al_key_down( & klawiatura, ALLEGRO_KEY_DOWN ) )
     				menu++;

				if( al_key_down( & klawiatura, ALLEGRO_KEY_UP ) )
     				menu--;
				
				if( menu > 2 )
     				menu = 2;
				
				if( menu < 0 )
         			menu = 0;
         
				switch( menu ) {
					case 0: {
					    al_draw_text (font_ttf_30,al_map_rgb(205,193,160), 270, 180,0,"RETRO GAME");
					    al_draw_text (font_ttf_30,al_map_rgb(84,43, 49), 270, 200,0,"MODERN GAME");
					    al_draw_text (font_ttf_30,al_map_rgb(84,43, 49), 270, 220,0,"EXIT");
					    al_flip_display();
					    break;
					    }
					case 1: {
					   	al_draw_text (font_ttf_30,al_map_rgb(84,43, 49), 270, 180,0,"RETRO GAME");
					    al_draw_text (font_ttf_30,al_map_rgb(205,193,160), 270, 200,0,"MODERN GAME");
					    al_draw_text (font_ttf_30,al_map_rgb(84,43, 49), 270, 220,0,"EXIT");
					    al_flip_display();
					    break;
					    }
					case 2: {
						al_draw_text (font_ttf_30,al_map_rgb(84,43, 49), 270, 180,0,"RETRO GAME");
					   	al_draw_text (font_ttf_30,al_map_rgb(84,43, 49), 270, 200,0,"MODERN GAME");
					    al_draw_text (font_ttf_30,al_map_rgb(205,193,160), 270, 220,0,"EXIT");
					    al_flip_display();
						break;
					}
				}
				
				show_score();
				
				czas=al_get_time();
					
					if(menu==2 && al_key_down( &klawiatura, ALLEGRO_KEY_ENTER)) {
         				exit(0);
					}
					
					if(menu==0 && al_key_down( &klawiatura, ALLEGRO_KEY_ENTER)) {
						skin=0;
						start_game();
						lvl = 1;
					}
					
					if(menu==1 && al_key_down( &klawiatura, ALLEGRO_KEY_ENTER)) {
						skin=1;
						start_game();
						lvl = 1;
					}
					
         	}
			 
		}    
	return 0;
    }
    
    void check_level(){
    	int flaga = 0; 
    	
		for(int i=0;i<num_of_enemy;++i){
    		if(enemy_position[i][0]>0 ){
    			flaga = 1; 
    		}
    	}	
    	
    	if (flaga == 0)
			lvl++;     	
    };
    
    
    int check_shoot_hero(){
		for(int i=0;i<num_of_shoot;++i){
				for(int j=0;j<num_of_enemy;++j){
					if(shoot_h[i][1]>enemy_position[j][1]+3) continue;
					int x1,x2;
					x1=enemy_position[j][0]+3;
					x2=enemy_position[j][0]+37;
						if(shoot_h[i][0]>=x1 && shoot_h[i][0]<=x2){
							enemy_position[j][0]=-100;
							enemy_position[j][1]=-100;
							shoot_h[i][0]=-10;
							shoot_h[i][1]=-10;
							wynik=wynik+50000;
							return 123;
							
						}
				}
		}
	};
	
	void check_shoot_enemy(){
		for(int i=0;i<num_of_shoot_enemy;++i){
			if(shoot_e[i][1]<y || shoot_e[i][1] > 499) continue;
					int x1, x2;
					x1=x+10;
					x2=x+30;
						if(shoot_e[i][0]>= x1 && shoot_e[i][0]<= x2){
							energy = energy - 10;
							shoot_e[i][1] = 600;
						}
		}
	};
	

	void end_game(){
			ALLEGRO_FONT *game_over = al_load_ttf_font("czcionka.ttf",80, 0);
			al_draw_text (game_over,al_map_rgb(255,255, 49), 150, 80,0,"Game Over");
			energy = 100;
			lvl = -1; 
			wynik = wynik-wynik;
			x= 310; 
			y = 400; 
			for (int j=0; j<num_of_enemy;++j) {
			enemy_position[j][0]=-100;
			enemy_position[j][1]=-100;
		    };
		    al_rest(0.5);
			generate_menu();
	};
	void show_score(){
		const char  *w1 = name1.c_str();
		const char  *w2 = name2.c_str();
		const char  *w3 = name3.c_str();

		ALLEGRO_FONT *wyraz = al_load_ttf_font("czcionka.ttf",15, 0);
				al_draw_textf(wyraz,al_map_rgb(242,229,195), 270, 320,0,"TOP PLAYERS:");
				al_draw_textf(wyraz,al_map_rgb(242,229,195), 270, 340,0,"%s : %3d", w1, score1);
				al_draw_textf(wyraz,al_map_rgb(242,229,195), 270, 355,0,"%s : %3d", w2, score2);
				al_draw_textf(wyraz,al_map_rgb(242,229,195), 270, 370,0,"%s : %3d", w3, score3);
				al_flip_display();

	};	
};
int main() {
	read_high();
	al_init();
	al_init_font_addon();
    al_init_ttf_addon();
    al_install_keyboard();
    al_init_image_addon();
    al_install_audio();
    al_init_acodec_addon();
	World *world=new World;
	world->generate_world();
	high.close();
	return 0;
}
