import React from 'react';
import {Link} from "react-router-dom";
import Icons from "../components/icons/Icons";

import svg from '../components/fire.svg'
import png from '../components/iconPort.png'

const Page1 = () => {
	return (
		<div>
			Page 1
			<br/>
			<Link to={'/page2'}>To Page 2</Link>
			<br/>
			<Link to={'/home'}>Home</Link>
			<br/>
			<img src={svg} alt=""/>
			<img src={png} alt=""/>
			{/*<Icons name={'arrow-right-simple'} size={48} />*/}
		</div>
	);
};

export default Page1;