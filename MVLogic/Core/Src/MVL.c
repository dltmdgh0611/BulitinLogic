/*
 * MVL.c
 *
 *  Created on: Feb 27, 2020
 *      Author: user
 */
#include "MVL.h"

_Bool fistToggles = 0;
_Bool Toggles = 0;
int AX = 0;
unsigned long count=0;
unsigned long fcount=0;
int logicarr[1024];
int xnext;
int x=0;
int movex=0;


int LogicAnalyzer(GPIO_TypeDef* GPIOx, uint16_t pinnum,int curdelay, int delay, int S, int StartTrigger, int totalbits){

	if(StartTrigger == 0){
		if(curdelay*10 == delay*S){
			AX++;
			if(AX == totalbits){
				return 2;
			}
			_Bool readpin = HAL_GPIO_ReadPin(GPIOx, pinnum);

			if(readpin){
				if(Toggles == readpin){
					logicarr[AX]=1;
				}
				else{
					logicarr[AX]=3;
				}
				Toggles = 1;
			}
			else{
				if(Toggles == readpin){
					logicarr[AX]=0;
				}
				else{
					logicarr[AX]=2;
				}
				Toggles = 0;
			}
			return 1;

		}
	}
	else if(StartTrigger == 2){
		//printf("%d\n",curdelay);
		if(curdelay == 3125){
			if(xnext !=0){
				if(x < 5){
					for(int i=0;i<5;i++){
						logicdraw(x+i,x+((xnext-1)*64)+i,logicarr, 1);
					}
				}
				if(x+5 < 64) logicdraw(x+5,x+((xnext-1)*64)+5,logicarr, 1);
			}
			logicdraw(x,x+(xnext*64),logicarr, 0);

			x++;
			if(x>63){
				xnext++;
				x=0;
			}
			if(64*xnext>=totalbits){
				return 4;
			}
			return 3;
		}
		return 5;

	}
	else if(StartTrigger == 4){
		AX=0;
		x=0;
		movex=0;
		StartTrigger=0;
		return 0;
	}
}

void logicdraw(int x,int arrx, int logicarr[], _Bool delflag){
	if(!delflag){
		if(logicarr[arrx] == 0){
			MVCD_dot_xy(x*2, 40);
			MVCD_dot_xy(x*2+1, 40);
		}
		else if(logicarr[arrx] == 1){
			MVCD_dot_xy(x*2, 20);
			MVCD_dot_xy(x*2+1, 20);
		}
		else if(logicarr[arrx] == 2){
			MVCD_dot_xy(x*2, 40);
			for(int i=1;i<=20;i++){
				MVCD_dot_xy(x*2, 40-i);
			}
			MVCD_dot_xy(x*2+1, 40);
		}
		else if(logicarr[arrx] == 3){
			MVCD_dot_xy(x*2, 20);
			for(int i=1;i<=20;i++){
				MVCD_dot_xy(x*2, 20+i);
			}
			MVCD_dot_xy(x*2+1, 20);
		}
	}
	else {
		if(logicarr[arrx] == 0){
			MVCD_deldot_xy(x*2, 40);
			MVCD_deldot_xy(x*2+1, 40);
		}
		else if(logicarr[arrx] == 1){
			MVCD_deldot_xy(x*2, 20);
			MVCD_deldot_xy(x*2+1, 20);
		}
		else if(logicarr[arrx] == 2){
			MVCD_deldot_xy(x*2, 40);
			for(int i=1;i<=20;i++){
				MVCD_deldot_xy(x*2, 40-i);
			}
			MVCD_deldot_xy(x*2+1, 40);
		}
		else if(logicarr[arrx] == 3){
			MVCD_deldot_xy(x*2, 20);
			for(int i=1;i<=20;i++){
				MVCD_deldot_xy(x*2, 20+i);
			}
			MVCD_deldot_xy(x*2+1, 20);
		}
	}
}



