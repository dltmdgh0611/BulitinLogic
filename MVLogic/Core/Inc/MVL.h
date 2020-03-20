/*
 * MVL.h
 *
 *  Created on: Feb 27, 2020
 *      Author: user
 */

#ifndef INC_MVL_H_
#define INC_MVL_H_
#include "stm32f4xx_hal.h"
#include <stdio.h>


#define US 1
#define MS 1000
#define SEC 1000000

int LogicAnalyzer(GPIO_TypeDef* GPIOx, uint16_t pinnum, int curdelay, int delay, int S, int StartTrigger, int totalbits);

#endif /* INC_MVL_H_ */
