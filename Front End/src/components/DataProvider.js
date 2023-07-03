import React, {createContext, useState} from 'react';

export const DataContext = createContext();

export const DataProvider = ({children}) => {
    const [myItems, setMyItems] = useState([]);
    const data = {
        myItems,
        setMyItems
    };
    return <DataContext.Provider value = {data}>{children}</DataContext.Provider>
}

