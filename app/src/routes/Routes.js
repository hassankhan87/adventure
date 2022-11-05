import React from 'react'
import { BrowserRouter, Routes, Route } from 'react-router-dom';
import TakeAdventure from '../views/adventure/TakeAdventure';
import CreateAdventure from '../views/adventure/CreateAdventure';
import MyAdventure from '../views/adventure/MyAdventure';

const MainRoutes = () => {
  return (
    <BrowserRouter>
        <Routes>
            <Route exact path='/' element={< CreateAdventure />}></Route>
            <Route exact path='/take/adventure/:id' element={< TakeAdventure />}></Route>
            <Route exact path='/my/adventure/:id' element={< MyAdventure />}></Route>
        </Routes>
    </BrowserRouter>
  )
}

export default MainRoutes