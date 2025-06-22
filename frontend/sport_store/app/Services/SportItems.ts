export interface SportItemRequest{
    title: string
    description: string
    price: number
}

export const getAllSportItems = async () => {
    const response = await fetch("http://localhost:5029/SportItems")

    return response.json()
}

export const createSportItem = async (sportItem: SportItemRequest) => {
    await fetch("http://localhost:5029/SportItems", {
        method: "POST",
        headers:{
            "content-type": "application/json"
        },
        body: JSON.stringify(sportItem)
    })
}

export const updateSportItem = async (id: string, sportItem: SportItemRequest) => {
    await fetch(`http://localhost:5029/SportItems/${id}`, {
        method: "PUT",
        headers:{
            "content-type": "application/json"
        },
        body: JSON.stringify(sportItem)
    })
}

export const deleteSportItem = async (id: string) => {
    await fetch(`http://localhost:5029/SportItems/${id}`, {
        method: "DELETE",
    })
}