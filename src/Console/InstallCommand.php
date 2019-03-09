<?php

namespace Almeidafranci\ObrSimulada\Console;

use Illuminate\Support\Str;
use Illuminate\Console\Command;
use Illuminate\Console\DetectsApplicationNamespace;

class InstallCommand extends Command
{
    use DetectsApplicationNamespace;

    /**
     * The name and signature of the console command.
     *
     * @var string
     */
    protected $signature = 'obrsimulada:install';

    /**
     * The console command description.
     *
     * @var string
     */
    protected $description = 'Install all of the OBR Simulada resources';

    /**
     * Execute the console command.
     *
     * @return void
     */
    public function handle()
    {
        $this->comment('Publishing OBR Simulada Assets...');
        $this->callSilent('vendor:publish', ['--tag' => 'obrsimulada-assets']);

        $this->comment('Publishing OBR Simulada Configuration...');
        $this->callSilent('vendor:publish', ['--tag' => 'obrsimulada-config']);

        $this->info('OBR Simulada scaffolding installed successfully.');
    }
}