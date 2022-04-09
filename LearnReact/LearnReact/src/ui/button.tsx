import React from 'react';


const styles =
{
	button:
	{
		padding: "1mm 2mm",
		display: "inline-block",
		border: "1px solid #000",
		borderRadius: "3mm",
		backgroundColor: "#fff",
		color: "#000"
	}
};




interface Props {
	onclick?: Function;
}






class Button extends React.Component<Props>
{
	static __id: number
	id: number
	constructor(props: Props)
	{
		super(props);

		this.id = Button.__id++;
		console.log("hi there");
		console.log(this);
		this.sayhi = this.sayhi.bind(this);
		
	}
	sayhi()
	{
		//this.props["data-onclick"]
		alert(this.id);
		if (this.props.onclick) this.props.onclick();
	}
	render()
	{
		return (
			<span style={styles.button} onClick={this.sayhi}>
				{
					this.props.children
				}
			</span>
			
		)
	}

}

var cc = Object.assign({}, Button);

declare global {
	var CButton:any
}

globalThis.CButton = Object.assign({}, Button);


//export default Button;
/*
declare global {
	function myFunction(): boolean;
	var myVariable: number;
}

globalThis.myFunction = () => true;
globalThis.myVariable = 42;*/

/*declare global {
	var CButton: Button;
}*/
/*globalThis.CButton = function (props:any) {
	return new Button(props)
}*/
//globalThis.CButton = Button;