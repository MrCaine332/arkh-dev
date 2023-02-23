import React from 'react';
import {Navigate, Route, Routes} from "react-router-dom";
import Page1 from "../pages/Page1";
import Page2 from "../pages/Page2";
import Home from "../pages/Home";

const Router = () => {
	return (
		<div>
			<Routes>
				<Route index element={<Home />} />
				<Route path={'/'} element={<Home />} />
				<Route path={'/home'} element={<Home />} />

				<Route path={'/page1'} element={<Page1 />} />
				<Route path={'/page2'} element={<Page2 />} />
				<Route path={'*'} element={<Navigate to={'/'} replace />} />
			</Routes>
		</div>
	);
};

export default Router;