/*
 * MVL.c
 *
 *  Created on: Feb 27, 2020
 *      Author: user
 */

#include "stm32f4xx_hal.h"

Toggles = 0;
AX = 0;

int LogicAnalyzer(GPIO_TypeDef* GPIOx, uint16_t pinnum, int delay, int S){
	printf("a");
	AX+=2;

	_Bool readpin = HAL_GPIO_ReadPin(GPIOx, pinnum);

	if(readpin){
		printf("high");
		if(Toggles == readpin){
			MVCD_dot_xy(AX, 20);
		}
		else{
			MVCD_dot_xy(AX, 20);
			for(int i=1;i<=20;i++){
				MVCD_dot_xy(AX, 20+i);
			}
		}
		MVCD_dot_xy(AX+1, 20);
		Toggles = 1;
	}
	else{
		printf("low");
		if(Toggles == readpin){
			MVCD_dot_xy(AX, 40);
		}
		else{
			MVCD_dot_xy(AX, 40);
			for(int i=1;i<=20;i++){
				MVCD_dot_xy(AX, 40-i);
			}
		}
		MVCD_dot_xy(AX+1, 40);
		Toggles = 0;
	}

	MVCD_delay_us(delay*S);

	if(AX > 127){
		AX = 0;
		return 1;
	}
}
