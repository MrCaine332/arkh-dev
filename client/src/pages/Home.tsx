import React from 'react';
import {Link} from "react-router-dom";
import Counter from "./Counter";

const Home = () => {
	return (
		<div>
			<h1>{ process.env.NODE_ENV } { process.env.REACT_APP_TITLE }</h1>
			<br/>
			<Link to={'/page1'}>To Page 1</Link>
			<br/>
			<Link to={'/page2'}>To Page 2</Link>
			<Counter />
		</div>
	);
};

export default Home;