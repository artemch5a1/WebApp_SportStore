type Props = {
  title: string
  description: string
  price: string
}

export default function ProductCard({ title, description, price }: Props) {
  return (
    <div className="card">
      <div className="card-body">
        <h3 className="card-title">{title}</h3>
        <p className="card-description">{description}</p>
        <p className="card-price">{price}</p>
      </div>
    </div>
  )
}