#!/usr/bin/env node

/**
 * FactCLI
 * A CLI script that provides random interesting fact 
 *
 * @author Alibek Seitov <https://reverateam.kz>
 */

const init = require('./utils/init');
const cli = require('./utils/cli');
const log = require('./utils/log');
const axios = require('axios')

const input = cli.input;
const flags = cli.flags;
const { clear, debug } = flags;

const getFact = async (apiKey, limit) =>  {
	var res = await axios.get('https://api.api-ninjas.com/v1/facts?limit=' + limit, {
		headers: {
			'X-Api-Key': apiKey
		}
	});
	return res;
} 

(async () => {
	init({ clear });
	input.includes(`help`) && cli.showHelp(0);
	if(input.includes('fact'))
	{
		const res = await getFact(flags.api, flags.limit);
		res.data.map((element)=>{
			console.log('Fact: ' + element.fact + '\n\n')
		})
	}
	debug && log(flags);
})();
