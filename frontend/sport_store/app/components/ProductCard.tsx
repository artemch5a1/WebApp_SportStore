type Props = {
  sportItems: SportItem[];
};

export default function ProductCard({ sportItems }: Props) {
  return (
    <>
      {sportItems.map((sportItem) => (
        <div className="card" key={sportItem.id}>
          <div className="card-body">
            <h3 className="card-title">{sportItem.title}</h3>
            <p className="card-description">{sportItem.description}</p>
            <p className="card-price">{sportItem.price}</p>
          </div>
        </div>
      ))}
    </>
  );
}
