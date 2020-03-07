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
int logicarr[64];
int x=0;


int LogicAnalyzer(GPIO_TypeDef* GPIOx, uint16_t pinnum,int curdelay, int delay, int S, int StartTrigger){

	if(StartTrigger == 0){
		if(curdelay*10 == delay*S){
			AX++;
			if(AX > 64){
				return 2;
			}
			_Bool readpin = HAL_GPIO_ReadPin(GPIOx, pinnum);

			if(readpin){
				if(Toggles == readpin){
					logicarr[AX]=1;
					//printf("h\n");
				}
				else{
					logicarr[AX]=3;
					//printf("h\n");
				}

				Toggles = 1;
			}
			else{
				if(Toggles == readpin){

					logicarr[AX]=0;
					//printf("l\n");
				}
				else{

					logicarr[AX]=2;
					//printf("l\n");
				}

				Toggles = 0;
			}
			return 1;

		}
	}
	else if(StartTrigger == 2){
		//printf("%d\n",curdelay);

		if(curdelay == 1000){
			if(logicarr[x] == 0){
				MVCD_dot_xy(x*2, 40);
				MVCD_dot_xy(x*2+1, 40);
			}
			else if(logicarr[x] == 1){
				MVCD_dot_xy(x*2, 20);
				MVCD_dot_xy(x*2+1, 20);
			}
			else if(logicarr[x] == 2){
				MVCD_dot_xy(x*2, 40);
				for(int i=1;i<=20;i++){
					MVCD_dot_xy(x*2, 40-i);
				}
				MVCD_dot_xy(x*2+1, 40);
			}
			else if(logicarr[x] == 3){
				MVCD_dot_xy(x*2, 20);
				for(int i=1;i<=20;i++){
					MVCD_dot_xy(x*2, 20+i);
				}
				MVCD_dot_xy(x*2+1, 20);
			}
			x++;
			if(x>63){
				x=0;
				return 4;
			}
			return 3;
		}
		return 5;

	}

}



