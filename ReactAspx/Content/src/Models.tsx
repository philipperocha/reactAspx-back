// A '.tsx' file enables JSX support in the TypeScript compiler, 
// for more information see the following page on the TypeScript wiki:
// https://github.com/Microsoft/TypeScript/wiki/JSX

export interface FoodModel {
    Id: number;
    Name: string;
    Description: string;
    Picture: string;
    Price: number;
    Quantity: number;
}

export interface IAppState {
    items: FoodModel[];
    myOrder: FoodModel[];
    showPopup: boolean;
    userId: number;
    orderPlaced: boolean;
}
