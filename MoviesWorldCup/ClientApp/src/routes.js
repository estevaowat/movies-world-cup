import React from "react";
import { Switch, Route } from "react-router-dom";

import SelectMovies from "./pages/SelectMovies";

export default function Routes() {
  return (
    <Switch>
      <Route path="/" exact component={SelectMovies} />
      <Route path="/teste" exact component={SelectMovies} />
    </Switch>
  );
}
