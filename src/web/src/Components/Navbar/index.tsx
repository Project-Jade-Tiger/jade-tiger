import { NavLink } from "react-router-dom";

const Navbar = () => {
    const activeStyle = "underline text-gray-500 underline-offset-4";
    return (

 <nav className="fixed top-0 z-10 flex items-center justify-between w-full px-8 py-5 font-light text-nd">
    <ul className="flex items-center gap-3">
        <li className="text-lg font-semibold">
            <NavLink to="/">Jade-Tiger</NavLink>
        </li>
        <li>
             <NavLink to="/"
                    className={({ isActive }) => (isActive ? activeStyle : undefined)}>
                        All
                </NavLink>
        </li>
         <li>
             <NavLink to="/clothing"
                    className={({ isActive }) => (isActive ? activeStyle : undefined)}>
                        Clothing
             </NavLink>
        </li>
        <li>
            <NavLink to="/electronics"
                    className={({ isActive }) => (isActive ? activeStyle : undefined)}>
                        Electronics
            </NavLink>
        </li>
        <li>
            <NavLink to="/sports"
                    className={({ isActive }) => (isActive ? activeStyle : undefined)}>
                        Sports
            </NavLink>
        </li>
        <li>
            <NavLink to="/toys"
                    className={({ isActive }) => (isActive ? activeStyle : undefined)}>
                        Toys
            </NavLink>
        </li>
        <li>
            <NavLink to="/furniture"
                    className={({ isActive }) => (isActive ? activeStyle : undefined)}>
                        Furniture
            </NavLink>
        </li>
        <li>
            <NavLink to="/Clearance"
                    className={({ isActive }) => (isActive ? activeStyle : undefined)}>
                        Clearance
            </NavLink>
        </li>
    </ul>
 </nav>     
)
}



export default Navbar;