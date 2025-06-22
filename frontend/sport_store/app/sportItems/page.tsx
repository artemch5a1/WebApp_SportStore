"use client";
import { useEffect, useState } from "react";
import ProductCard from "../components/ProductCard";
import { getAllSportItems } from "../Services/SportItems";


export default function HomePage() {
  const [productsAPI, setProduct] = useState<SportItem[]>([]);

  const [loading, setLoading] = useState<boolean>(true);

  useEffect(() => {
    const getProduct = async () => {
      const productsFetch = await getAllSportItems();
      setLoading(false);
      setProduct(productsFetch);
      console.log("Полученный список товаров:", productsAPI);
    };

    getProduct();
  }, []);

  return (
    <section className="container">
      <h2>Популярные товары</h2>
      <div className="grid">
        <ProductCard sportItems={productsAPI} />
      </div>
    </section>
  );
}
