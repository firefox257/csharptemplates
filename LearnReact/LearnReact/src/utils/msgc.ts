import React from 'react';





class Msgc
{
	static msgclist: { [key: string]: Array<Function> } = {}
	static Handle(id: string, func: Function)
	{
		if (Msgc.msgclist[id] == undefined) Msgc.msgclist[id] = new Array<Function>();
		Msgc.msgclist[id].push(func);
	}
}