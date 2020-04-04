import React from "react";
import { Switch, Route } from "react-router-dom";

import SelectMovies from "./pages/SelectMovies";
import Result from "./pages/Result";
export default function Routes() {
  return (
    <Switch>
      <Route path="/" exact component={SelectMovies} />
      <Route path="/resultado" exact component={Result} />
    </Switch>
  );
}
