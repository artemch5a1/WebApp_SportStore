'use client';
import ProductCard from '../components/SportItemCard'

const products = [
  {
    id: 1,
    title: 'Фитнес-коврик',
    description: 'Удобный коврик для занятий йогой и фитнесом.',
    price: '₽1,490',
  },
  {
    id: 2,
    title: 'Гантели 10 кг',
    description: 'Универсальные гантели для домашних тренировок.',
    price: '₽2,990',
  },
  {
    id: 3,
    title: 'Скакалка',
    description: 'Прочная скакалка для кардиотренировок.',
    price: '₽690',
  },
  {
    id: 4,
    title: 'Футбольный мяч',
    description: 'Официальный размер, подойдёт для игры на улице.',
    price: '₽1,790',
  },
]

export default function HomePage() {
  return (
    <section className="container">
      <h2>Популярные товары</h2>
      <div className="grid">
        {products.map((product) => (
          <ProductCard key={product.id} {...product} />
        ))}
      </div>
    </section>
  )
}
