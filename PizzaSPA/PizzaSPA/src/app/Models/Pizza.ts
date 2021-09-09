export interface Pizza {
    id: number;
    name: string;
    prizeForSmall: number;
    prizeForLarge: number;
    image: string;
}

export interface PizzaDescriptionDTO {
    id: number;
    name: string;
    image: string;
    description: string;
    ingridients: string;
    like: number;
    dislike: number;
}
