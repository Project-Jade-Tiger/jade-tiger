import {useRoutes, BrowserRouter as Router} from 'react-router-dom';

import './App.css';
import Home from './Pages/Home';
import MyAccount from './Pages/MyAccount';
import MyOrder from './Pages/MyOrder';
import MyOrders from './Pages/MyOrders';
import NotFound from './Pages/NotFound';
import SignIn from './Pages/SignIn';
import Navbar from './Components/Navbar/index'; 

const AppRoutes = () => {
  const routes = useRoutes([
    {path: '/', element: <Home/>},
    {path: '/my-account', element: <MyAccount/>},
    {path: '/my-orders', element: <MyOrders/>}, 
    {path: '/sign-in', element: <SignIn/>}, 
    {path: '*', element: <NotFound/>}
  ]);
return routes;
};

//<MyOrder/> added below to remove error in import statement
//Not included in instructions

function App() {
  return(
    <Router>
      <Navbar/>
      <AppRoutes/>
      <MyOrder/>
    </Router>
  );
}

  export default App;
