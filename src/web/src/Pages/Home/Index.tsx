import  { useEffect, useState } from "react";
import axios from "axios";

import Layout from "../../Components/Layout";
import { Product } from "../../Models/Product";

const Home: React.FC = () => {
    const [products, setProducts] = useState<Product[]>([]);
    
    useEffect(() => {
        axios.get<Product[]>("https://localhost:5001/api/catalog/", {
            headers: {
                "Content-Type": "application/json",
            },
        })
        .then((response) => setProducts(response.data))
        .catch((error) => console.error(error));
    }, []);
    
    return (
        <div>
        <Layout>
            <h1>Home</h1>
            {products.map((product) => (
                <div key={product.id}>
                    <h2>{product.name}</h2>
                    <p>{product.price}</p>
                </div>
            ))}
        </Layout>
        </div>
    );
};

export default Home;