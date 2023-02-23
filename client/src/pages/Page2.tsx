import React from 'react';
import {Link} from "react-router-dom";

const Page2 = () => {
	return (
		<div>
			Page 2
			<br/>
			<Link to={'/page1'}>To Page 1</Link>
			<br/>
			<Link to={'/home'}>Home</Link>
		</div>
	);
};

export default Page2;