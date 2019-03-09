<?php

namespace Almeidafranci\ObrSimulada;

use Illuminate\Support\Facades\Route;
use Illuminate\Support\ServiceProvider;

class ObrSimuladaServiceProvider extends ServiceProvider
{
    /**
     * Bootstrap any package services.
     *
     * @return void
     */
    public function boot()
    {
        $this->registerRoutes();
        $this->registerPublishing();
        $this->loadViewsFrom(
            __DIR__.'/../resources/views', 'obrsimulada'
        );
    }

    /**
     * Register the package routes.
     *
     * @return void
     */
    private function registerRoutes()
    {
        Route::group($this->routeConfiguration(), function () {
            $this->loadRoutesFrom(__DIR__.'/Http/routes.php');
        });
    }

    /**
     * Get the OBR Simulada route group configuration array.
     *
     * @return array
     */
    private function routeConfiguration()
    {
        return [
            'namespace' => 'Almeidafranci\ObrSimulada\Http\Controllers',
            'prefix' => config('obrsimulada.path'),
        ];
    }

    /**
     * Register the package's publishable resources.
     *
     * @return void
     */
    private function registerPublishing()
    {
        if ($this->app->runningInConsole()) {
            $this->publishes([
                __DIR__.'/../public' => public_path('vendor/obrsimulada'),
            ], 'obrsimulada-assets');
            $this->publishes([
                __DIR__.'/../config/obrsimulada.php' => config_path('obrsimulada.php'),
            ], 'obrsimulada-config');
        }
    }

    /**
     * Register any package services.
     *
     * @return void
     */
    public function register()
    {
        $this->mergeConfigFrom(
            __DIR__.'/../config/obrsimulada.php', 'obrsimulada'
        );
        $this->commands([
            Console\InstallCommand::class,
        ]);
    }

}