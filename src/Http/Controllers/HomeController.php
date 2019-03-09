<?php

namespace Almeidafranci\ObrSimulada\Http\Controllers;

use Illuminate\Routing\Controller;

class HomeController extends Controller
{
    /**
     * Display the OBR Simulada view.
     *
     * @return \Illuminate\Http\Response
     */
    public function index()
    {
        return view('obrsimulada::layout');
    }
}